using MySql.Data.MySqlClient;
using Proyecto_BD.Enumerables;
using System.Data;
namespace Proyecto_BD.Models
{
    public static class DBContext
    {
        //Creamos el objeto que sostiene la conexion
        private static MySqlConnection connection;
        //Creamos el objeto que genera los comandos de SQL
        private static MySqlCommand command;
        //Creamos el objeto que lee la respuesta de SQL
        private static MySqlDataReader reader;
        //Obtenemos un ID del usuario que se conecta
        public static string ID_user_connected;
        //Obtenemos el ROL del usuario que se conecta
        public static TypeRole rol;
        //Generamos una funcion cuando el usuario se conecte para obtener los datos mas importantes
        private static void OnUserConected(string user)
        {
            // Generamos un comando de SQL que adquiera el primer ID del usuario que este
            using (command = new MySqlCommand("SELECT id_US FROM usuarios WHERE Nom_US = @ID AND stat_us = 1 LIMIT 1;"))
            {
                //Le damos al comando la conexion a la base de datos
                command.Connection = connection;
                //Le mandamos los parametros con el valor
                command.Parameters.AddWithValue("@ID", user);
                //Preparamos la consulta
                command.Prepare();
                //Usamos el using para que este al terminar sea eliminado la instancia
                using (reader = command.ExecuteReader())
                {
                    //Esperamos mientras lee
                    while (reader.Read())
                    {
                        //Obtenemos el ID del usuario conectado
                        ID_user_connected = reader["id_US"]?.ToString() ?? string.Empty;
                    }
                }
            }
            //Generamos una nueva consulta para saber el rol actual del usuario conectado
            using (command = new MySqlCommand("SELECT current_role();"))
            {
                //Le damos la conexion
                command.Connection = connection;
                //Usamos el using para que este al terminar sea eliminado la instancia
                using (reader = command.ExecuteReader())
                {
                    //Esperamos mientras lee
                    while (reader.Read())
                    {
                        // Generamos el rol, haciendo un parse a enumerable
                        rol = Enum.Parse<TypeRole>((reader["current_role()"]?.ToString() ?? string.Empty).Split("`")[1]);
                    }
                }
            }
        }
        // Generamos un metodo estatico para conectar la base de datos (como prueba)
        public static void ConnectDataBase(string ConnectionString)
        {
            //Declaramos un contador
            int i = 0;
            //Generamos la conexion
            connection = new MySqlConnection(ConnectionString);
            do
            {
                //tratamos de abrir la conexion
                connection.Open();
                //Si la conexion no esta abierta lo intentamos de nuevo
                if ((connection.State & System.Data.ConnectionState.Open) < 0)
                {
                    //Sumamois el contador
                    i++;
                }
                else if (i == 3)
                {
                    // Enviamos un error de que no se pudo conectar
                    throw new Exception("No se pudo conectar a la base de datos");
                }
                else
                {
                    //Aumentamos el contador
                    i = 4;
                }
                //Lo intentamos tres veces
            } while (i < 3);
            //Cierra la base de datos
            connection.Close();
        }
        //Funcion para conecatar a un usuario especifico a una base de datos
        public static void Connect_userToDatabase(string user, string password)
        {
            //Generamos una nueva cadena de conexion con el usuario y la contraseña dadas
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
            {
                //Le decimos que se conecte en el servidor local
                Server = "127.0.0.1",
                //Le decimos que en el puerto 3306
                Port = 3306,
                //Le decimos que base de datos
                Database = "IMAGINE_MOBILE_DB",
                //Que usuario
                UserID = user,
                //Que contraseña
                Password = password,
                //Sin confirmacion por SSl
                SslMode = MySqlSslMode.Disabled,
                //Que permita a la aplicacion conectarse
                AllowPublicKeyRetrieval = true,

            };
            //Generamos la conexion
            connection = new MySqlConnection(builder.ConnectionString);
            //Abrimos la conexion con la base de datos
            connection.Open();
            //Mandamos a llamar a la funcion para que adquiera los datos
            OnUserConected(user);
        }
        //Evento para cuando se salga de la aplicacion
        public static void OnApplicationExit(object sender, EventArgs e)
        {
            //Si hay una conexion o esta no esta cerrada
            if (connection != null && connection.State == ConnectionState.Open)
            {
                //Cerramos la conexion por seguridad
                connection.Close();
            }

            //Cerramos la aplicacion
            Application.Exit();
        }

        public static void CloseEmergencie()
        {
            //Si hay una conexion o esta no esta cerrada
            if (connection != null && connection.State == ConnectionState.Open)
            {
                //Cerramos la conexion por seguridad
                connection.Close();
            }
        }
        //Metodo para hacer la adaptacion a un usuario, toma como parametro el lector
        private static Usuarios ParseTableToUser(MySqlDataReader lector)
        {
            //Realizara la busqueda de los campos donde este el ID, y se hara el parseo de Binary o un arreglo de bits a caracter a tipo de rol, y la fecha en la que se unio
            Usuarios retorno = new Usuarios(lector["id_US"].ToString(), (TypeRole)char.GetNumericValue((char)((byte[])lector["tipo_usuario"])[0]), Convert.ToDateTime(lector["fching_Us"]))
            {
                //Realiza la busqueda de los campos del nombre
                Nom_US = lector["Nom_US"]?.ToString(),
                //Realiza la busqueda de los campos del apellido paterno
                Ap_Us = lector["Ap_US"]?.ToString(),
                //Realiza la busqueda de los campos del apellido materno
                Am_Us = lector["Am_US"]?.ToString(),
                //Realiza la busqueda de los campos del rfc
                rfc_Us = lector["rfc_Us"]?.ToString(),
                //Realiza la busqueda de los campos del curp
                curp_us = lector["curp_US"]?.ToString(),
                //Realiza la busqueda de los campos del numero de seguridad socual
                nss_Us = lector["nss_Us"]?.ToString(),
                //Realiza la busqueda de los campos del telefono
                Tel_Us = Convert.ToDouble(lector["Tel_Us"]),
                //Realiza la busqueda de los campos del correo electronico
                correo_electronico = lector["correo_electronico"].ToString(),
                //Realiza la busqueda de los campos del
                fchNac_Us = Convert.ToDateTime(lector["fchNac_Us"]),
            };
            //Devuelve el usuario
            return retorno;
        }
        //Metood para hacer la adaptacion al proveedor, se toma como parametro el lector de la bd
        private static Proveedor ParseTableToSupplier(MySqlDataReader lector)
        {
            //Creamos un nuevo proveedor que reciba el campo del id
            Proveedor retorno = new Proveedor(lector["Id_Prov"].ToString())
            {
                //Buscamos el campo en el lector para la propiedad para el RFC del proveedor
                rfc_Prov = lector["rfc_Prov"].ToString(),
                //Buscamos el campo en el lector para la propiedad para el nombre del proveedor
                Nom_Prov = lector["Nom_Prov"].ToString(),
                //Buscamos el campo en el lector para la propiedad para el represenante del proveedor
                Rep_prov = lector["Rep_prov"]?.ToString() ?? null,
                //Buscamos el campo en el lector para la propiedad para la direccion del proveedor
                Dir_prov = lector["Dir_prov"].ToString(),
                //Buscamos el campo en el lector para la propiedad del numero del proveedor
                Num_Prov = lector["Num_Prov"].ToString(),
                //Buscamos el campo en el lector para la propiedad del correo del proveedor
                Correo_prov = lector["Correo_prov"].ToString(),
            };
            return retorno;
        }
        //Metodo para adaptar la tabla a los productos
        private static Productos ParseTableToProducts(MySqlDataReader lector)
        {
            //Generamos un nuevo Producto y buscamos en la consulta el tipo y el id que le corresponde
            Productos retorno = new Productos((TypeOfProductos)Convert.ToInt32(lector["tipo"]), lector["id_producto"].ToString())
            {
                //Buscamos en la consulta la columna donde esta ubicado el modelo y lo asignamos a la propiedad
                modelo = Convert.ToDouble(lector["Modelo"]),
                //Buscamos en la consulta la columna donde esta ubicado el precio y lo asignamos a la propiedad
                precio = Convert.ToInt32(lector["Precio"]),
                //Buscamos en la consulta la columna donde esta ubicado el cantidad y lo asignamos a la propiedad
                cantidad = Convert.ToInt32(lector["Cantidad"]),
                //Buscamos en la consulta la columna donde esta ubicado el id de los campos extra y lo asignamos a la propiedad
                campos_Extra = new Campos_extra(lector["id_campos_extra"].ToString())
                {
                    //Generamos un nuevo y buscamos en la consulta si existe la epecificacion, si existe instanciamos el ID y el tipo sino lo pasamos como nulo
                    especificacion = lector["id_especificaciones"] is null ? null : new Caracteristica_especifica(TypeExtra.ESPECIFICACIONES, reader["id_especificaciones"].ToString())
                    {
                        //Buscamos en la consulta el campo y lo asignamos a la propiedad
                        caracteristica = lector["Especificacion"].ToString()
                    },
                    //Generamos un nuevo y buscamos en la consulta si existe el metodo de comunicacion, si existe instanciamos el ID y el tipo sino lo pasamos como nulo
                    comunicacion = lector["id_comunicacion"] is null ? null : new Caracteristica_especifica(TypeExtra.METODOS_DE_COMUNICACION, reader["id_comunicacion"].ToString())
                    {
                        //Buscamos en la consulta el campo y lo asignamos a la propiedad
                        caracteristica = lector["Metodo_comunicacion"].ToString()
                    },
                    //Generamos un nuevo y buscamos en la consulta si existe la accesorio, si existe instanciamos el ID y el tipo sino lo pasamos como nulo
                    accesorios = lector["id_accesorios"] is null ? null : new Caracteristica_especifica(TypeExtra.ACCESORIOS, lector["id_accesorios"].ToString())
                    {
                        //Buscamos en la consulta el campo y lo asignamos a la propiedad
                        caracteristica = lector["Accesorios"].ToString()
                    },
                    //Generamos un nuevo y buscamos en la consulta si existe la tecnologia, si existe instanciamos el ID y el tipo sino lo pasamos como nulo
                    tecnologias = lector["id_tecnologias"] is null ? null : new Caracteristica_especifica(TypeExtra.TECNOLOGIAS, lector["id_tecnologias"].ToString())
                    {
                        //Buscamos en la consulta el campo y lo asignamos a la propiedad
                        caracteristica = lector["Tecnologia"].ToString()
                    },
                    //Generamos un nuevo y buscamos en la consulta si existe el metodo de compatibilidad, si existe instanciamos el ID y el tipo sino lo pasamos como nulo
                    compatibilidad = lector["id_compatibilidad"] is null ? null : new Caracteristica_especifica(TypeExtra.METODOS_DE_COMUNICACION, lector["id_compatibilidad"].ToString())
                    {
                        //Buscamos en la consulta el campo y lo asignamos a la propiedad
                        caracteristica = lector["Compatibilidad"].ToString()
                    },
                    color = lector["Color"].ToString(),
                    capacida = lector["Capacidad"] is DBNull ? null : Convert.ToInt32(lector["Capacidad"]),
                    material = lector["Material"].ToString(),
                    tamaño = lector["Tamaño"].ToString()
                }
            };
            return retorno;
        }
        //Metodo para adaptar la tabla a un producto, sin sus campos extra completos
        private static Productos ParseNotCompleteTableToProducts(MySqlDataReader lector)
        {
            //Instanciamos un nuevo producto y a este le pasamos el tipo y el id que estan en la consulta
            Productos retorno = new Productos((TypeOfProductos)Convert.ToInt32(lector["tipo"]), lector["id_producto"].ToString())
            {
                //Buscamos en la consulta el campo y lo asignamos a la propiedad
                modelo = Convert.ToDouble(lector["Modelo"]),
                //Buscamos en la consulta el campo y lo asignamos a la propiedad
                precio = Convert.ToInt32(lector["Precio"]),
                //Buscamos en la consulta el campo y lo asignamos a la propiedad
                cantidad = Convert.ToInt32(lector["Cantidad"]),
                //Buscamos en la consulta el campo y lo instranciamos pasandolo al constructor
                campos_Extra = new Campos_extra(lector["id_campos_extra"].ToString())
            };
            return retorno;

        }
        //Metodo para adaptar la tabla a de ventas
        private static Venta ParseVentas(MySqlDataReader lector)
        {
            //Instanciamos una nueva venta, pasandole como atributo el campo del ID
            Venta venta = new Venta(Convert.ToString(lector["Id_venta"]))
            {
                //Buscamos en la consulta el valor y lo asignamos a la propiedad
                Fecha_venta = Convert.ToDateTime(lector["Fecha_venta"]),
                //Buscamos en la consulta el valor y lo asignamos a la propiedad
                Hora_Venta = TimeSpan.Parse(lector["Hora_Venta"].ToString()),
                //Buscamos en la consulta el valor y lo asignamos a la propiedad
                Cant_venta = Convert.ToInt32(lector["Cant_venta"]),
                //Buscamos en la consulta el valor y lo asignamos a la propiedad
                Precio_venta = Convert.ToInt32(lector["Precio_Venta"]),
                //Buscamos en la consulta el valor y lo asignamos a la propiedad
                Total_Venta = Convert.ToInt32(lector["Total_Venta"]),
                //Buscamos en la consulta el valor y lo asignamos a la propiedad
                Pago_venta = (TypeOfPay)Convert.ToInt32(lector["Pago_venta"])
            };
            return venta;
        }
        //Metodo para adaptar la tabla a una caracteristica especifica recibe el lector y el tipo
        private static Caracteristica_especifica ParseTableToSpec(MySqlDataReader lector, TypeExtra extra)
        {
            // Instanciamos una caracteristica especifica y que esta reciba del lector el id
            Caracteristica_especifica caracteristica = new Caracteristica_especifica(extra, lector[0].ToString())
            {
                //Le asignamo el valor del segundo campo
                caracteristica = lector[1].ToString()
            };
            return caracteristica;
        }
        //Metodo que nos retornara si ya existe un ID especifico para una caracteristica especifica
        public static bool ExistID(Caracteristica_especifica caracteristica)
        {
            //Creamos dos valores para ver cual es la tabla y cual es la columna del ID
            string table = string.Empty, column = string.Empty;
            bool retorno = false;
            //Atraves de la caracteristica asignamos la columna y la tabla
            switch (caracteristica.tipo)
            {
                case TypeExtra.COMPATIBILIDAD:
                    {
                        table = "Compatibilidad";
                        column = "id_compatibilidad";
                        break;
                    }
                case TypeExtra.ACCESORIOS:
                    {
                        table = "Accesorios_productos";
                        column = "id_accesorios";
                        break;
                    }
                case TypeExtra.ESPECIFICACIONES:
                    {
                        table = "Especificaciones";
                        column = "id_especificaciones";
                        break;
                    }
                case TypeExtra.TECNOLOGIAS:
                    {
                        table = "Tecnologias";
                        column = "id_tecnologias";
                        break;
                    }
                case TypeExtra.METODOS_DE_COMUNICACION:
                    {
                        table = "Metodos_de_comunicacion";
                        column = "id_comunicacion";
                        break;
                    }
            }
            //Le damos el comando al comando de Mysql, insertamos la columna y la tabla (esto no se deberia hacer)
            using (command = new MySqlCommand(string.Format("SELECT CASE WHEN EXISTS (SELECT 1 FROM {0} WHERE {1} = @ID) THEN 1 ELSE 0 END AS existe_campo;", table, column)))
            //using (command = new MySqlCommand(string.Format("SELECT Count(id_accesorios) as cuenta FROM {0} WHERE {1} = @ID;", table, column)))
            {
                //Le damos la conexion
                command.Connection = connection;
                //Le asignamos un parametros
                command.Parameters.AddWithValue("@ID", caracteristica.Id_Ca);
                //Le decimos que genere el comando
                command.Prepare();
                //Recibimos el primer valor que de la consulta y lo convertimos a booleano
                retorno = Convert.ToBoolean(command.ExecuteScalar());
                //using (reader = command.ExecuteReader())
                //{
                //    if (reader.HasRows)
                //    {
                //        while (reader.Read())
                //        {
                //            //retorno = Convert.ToBoolean(reader["existe_campo"]);
                //            retorno = Convert.ToInt32(reader["cuenta"]) > 0;

                //        }
                //    }
                //}
            }
            //Devolvemos el valor
            return retorno;
        }
        //Metodo para insertar el usuario, tomando como parametro el nuevo usuario y la contraseña
        public static bool InsertUser(Usuarios nvo_usuario, string password)
        {
            bool result = true;
            //Le damos el comando para que inserte el nvo usuario con todos los parametros
            using (command = new MySqlCommand(@"INSERT into usuarios values(@ID,@Nombre,@apellido_pa,@apellido_ma,@RFC,@CURP,@NSS,@TEL,@Correo,@Nacimiento,@fecha,@tipo,@status);"))
            {
                //Le damos la conecion al comando
                command.Connection = connection;
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@ID", nvo_usuario.id_US);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@Nombre", nvo_usuario.Nom_US);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@apellido_pa", nvo_usuario.Ap_Us);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@apellido_ma", nvo_usuario.Am_Us);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@RFC", nvo_usuario.rfc_Us);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@CURP", nvo_usuario.curp_us);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@NSS", nvo_usuario.nss_Us);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@TEL", nvo_usuario.Tel_Us);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@Correo", nvo_usuario.correo_electronico);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@Nacimiento", nvo_usuario.fchNac_Us);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@fecha", nvo_usuario.Fching_Us);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@tipo", nvo_usuario.Rol);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@status", nvo_usuario.Status);
                //Le asignamos los parametros en el metodo su valor
                command.Parameters.AddWithValue("@contrasena", password);
                //Preparamos la consulta
                command.Prepare();
                //Realizamos la conuslta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result = result & command.ExecuteNonQuery() == 1;
            }
            //Le damos al comando el nuevo comando, este le insertamos atraves de la cadena el nuevno usuario y la contraseña
            using (command = new MySqlCommand(String.Format("CREATE user '{0}'@'localhost' IDENTIFIED BY '{1}'", nvo_usuario.Nom_US, password)))
            {
                //Le damos la conecion al comando
                command.Connection = connection;
                //Realizamos la conuslta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result = result & command.ExecuteNonQuery() == 1;
            }
            //Le damos el comando, diciendole que se le garantice el rol de empleado al nvo usuario
            using (command = new MySqlCommand(String.Format("GRANT EMPLEADO to '{0}'@'localhost'", nvo_usuario.Nom_US)))
            {
                //Le damos la conecion al comando
                command.Connection = connection;
                //Realizamos la conuslta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result = result & command.ExecuteNonQuery() == 1;
            }
            //Devolvemos el resultado
            return result;
        }
        //Metodo para insertar la nueva caracterisitca especifica
        public static bool InsertSpecificFeature(Caracteristica_especifica caracteristica)
        {
            //Creamos una variable para el resultado
            bool result = true;
            //Creamos una variable par la tabla
            string table = string.Empty;
            //Le asignamos que tabla sera a la tabla
            switch (caracteristica.tipo)
            {
                case TypeExtra.COMPATIBILIDAD:
                    table = "Compatibilidad";
                    break;
                case TypeExtra.ACCESORIOS:
                    table = "Accesorios_productos";
                    break;
                case TypeExtra.ESPECIFICACIONES:
                    table = "Especificaciones";
                    break;
                case TypeExtra.TECNOLOGIAS:
                    table = "Tecnologias";
                    break;
                case TypeExtra.METODOS_DE_COMUNICACION:
                    table = "Metodos_de_comunicacion";
                    break;
            }
            //Le asignamos el comando, con los dos parametros que es el ID y la descricion, y le damos formato a la consulta agregandole la tabla
            using (command = new MySqlCommand(string.Format("INSERT INTO {0} VALUES(@ID,@descripcion);", table)))
            {
                //Le damos la conecion al comando
                command.Connection = connection;
                //Le asignamos el parametro con su valor
                command.Parameters.AddWithValue("@ID", caracteristica.Id_Ca);
                //Le asignamos el parametro con su valor
                command.Parameters.AddWithValue("@descripcion", caracteristica.caracteristica);
                //Le pedimos que prepare la consulta
                command.Prepare();
                //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result = result & command.ExecuteNonQuery() == 1;
            }

            return result;
        }
        //Metodo para insertar el nuevo campo extra del producto
        public static bool InsertExtraCamps(Campos_extra extra)
        {
            bool result = true;
            //Generamos la consulta del nuevo producto con sus parametros correspondientes
            using (command = new MySqlCommand("INSERT INTO Campos_extra VALUES(@ID,@spec,@com,@comu,@acc,@tec,@color,@material,@tamaño,@capacidad)"))
            {
                //Le damos la conecion al comando
                command.Connection = connection;
                //Al comando le asignamos los parametros con su valor
                command.Parameters.AddWithValue("@ID", extra.ID_campos_extra);
                //Al comando le asignamos los parametros con su valor
                command.Parameters.AddWithValue("@spec", extra.especificacion?.Id_Ca ?? null);
                //Al comando le asignamos los parametros con su valor
                command.Parameters.AddWithValue("@com", extra.compatibilidad?.Id_Ca ?? null);
                //Al comando le asignamos los parametros con su valor
                command.Parameters.AddWithValue("@comu", extra.comunicacion?.Id_Ca ?? null);
                //Al comando le asignamos los parametros con su valor
                command.Parameters.AddWithValue("@acc", extra.accesorios?.Id_Ca ?? null);
                //Al comando le asignamos los parametros con su valor
                command.Parameters.AddWithValue("@tec", extra.tecnologias?.Id_Ca ?? null);
                //Al comando le asignamos los parametros con su valor
                command.Parameters.AddWithValue("@color", extra.color);
                //Al comando le asignamos los parametros con su valor
                command.Parameters.AddWithValue("@material", extra.material);
                //Al comando le asignamos los parametros con su valor
                command.Parameters.AddWithValue("@tamaño", extra.tamaño);
                //Al comando le asignamos los parametros con su valor
                command.Parameters.AddWithValue("@capacidad", extra.capacida);
                //Le pedimos que prepare la consulta
                command.Prepare();
                //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result = result & command.ExecuteNonQuery() == 1;
            }
            return result;
        }
        //Metodo para insertar el nuevo producto
        public static bool InsertProduct(Productos nvo_producto)
        {
            bool result = true;
            //Generamos la consulta para insertar el producto correspondiente con sus correspondientes parametros
            using (command = new MySqlCommand("INSERT INTO productos VALUES(@ID,@ID_extra,@tipo,@modelo,@precio,@cantidad,1);"))
            {
                //Le damos la conecion al comando
                command.Connection = connection;
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@ID", nvo_producto.Id_productos);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@ID_extra", nvo_producto.campos_Extra.ID_campos_extra);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@tipo", nvo_producto.tipo);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@modelo", nvo_producto.modelo);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@precio", nvo_producto.precio);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@cantidad", nvo_producto.cantidad);
                //Le pedimos que prepare la consulta
                command.Prepare();
                //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result = result & command.ExecuteNonQuery() == 1;
            }
            return result;
        }
        //Metodo para insertar el nuevo
        public static bool InsertRelation(string id_Prov, string id_producto)
        {
            bool result = true;
            using (command = new MySqlCommand("INSERT INTO productos_a_vender VALUES(NULL,@Id_Prov,@id_producto);"))
            {
                //Le damos la conecion al comando
                command.Connection = connection;
                //Le damos los parametros con el valor asignafo
                command.Parameters.AddWithValue("@Id_Prov", id_Prov);
                //Le damos los parametros con el valor asignafo
                command.Parameters.AddWithValue("@id_producto", id_producto);
                //Le pedimos que prepare la consulta
                command.Prepare();
                //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result = result & command.ExecuteNonQuery() == 1;
            }
            return result;
        }
        //Metodo para insertar el nuevo Proveedor
        public static bool InsertSupplier(Proveedor nvo_proveedor)
        {
            bool result = true;
            using (command = new MySqlCommand("INSERT INTO proveedor VALUES(@ID,@Rfc,@nombre,@Rep,@Dir,@correo,@tel,1);"))
            {
                //Le damos la conecion al comando
                command.Connection = connection;
                //Le asignamos los parametros y le asignamos el valor
                command.Parameters.AddWithValue("@ID", nvo_proveedor.Id_Prov);
                //Le asignamos los parametros y le asignamos el valor
                command.Parameters.AddWithValue("@Rfc", nvo_proveedor.rfc_Prov);
                //Le asignamos los parametros y le asignamos el valor
                command.Parameters.AddWithValue("@nombre", nvo_proveedor.Nom_Prov);
                //Le asignamos los parametros y le asignamos el valor
                command.Parameters.AddWithValue("@Rep", nvo_proveedor.Rep_prov);
                //Le asignamos los parametros y le asignamos el valor
                command.Parameters.AddWithValue("@Dir", nvo_proveedor.Dir_prov);
                //Le asignamos los parametros y le asignamos el valor
                command.Parameters.AddWithValue("@correo", nvo_proveedor.Correo_prov);
                //Le asignamos los parametros y le asignamos el valor
                command.Parameters.AddWithValue("@tel", nvo_proveedor.Num_Prov);
                //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result = result & command.ExecuteNonQuery() == 1;
            }
            return result;
        }
        //Metodo para insertar el nuevo
        public static bool InsertarCompleteTheSupplier(Proveedor nvo_proveedor, List<Productos> nw_products)
        {
            bool result = true;
            foreach (Productos nw_producto in nw_products)
            {
                //Preguntamos si el campo extra no es nulo y si no existe su id
                if (nw_producto.campos_Extra.accesorios is not null && !ExistID(nw_producto.campos_Extra.accesorios))
                {
                    //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                    result &= InsertSpecificFeature(nw_producto.campos_Extra.accesorios);
                }
                //Preguntamos si el campo extra no es nulo y si no existe su id
                if (nw_producto.campos_Extra.compatibilidad is not null && !ExistID(nw_producto.campos_Extra.compatibilidad))
                {
                    //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                    result &= InsertSpecificFeature(nw_producto.campos_Extra.compatibilidad);
                }
                //Preguntamos si el campo extra no es nulo y si no existe su id
                if (nw_producto.campos_Extra.comunicacion is not null && !ExistID(nw_producto.campos_Extra.comunicacion))
                {
                    //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                    result &= InsertSpecificFeature(nw_producto.campos_Extra.comunicacion);
                }
                //Preguntamos si el campo extra no es nulo y si no existe su id
                if (nw_producto.campos_Extra.especificacion is not null && !ExistID(nw_producto.campos_Extra.especificacion))
                {
                    //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                    result &= InsertSpecificFeature(nw_producto.campos_Extra.especificacion);
                }
                //Preguntamos si el campo extra no es nulo y si no existe su id
                if (nw_producto.campos_Extra.tecnologias is not null && !ExistID(nw_producto.campos_Extra.tecnologias))
                {
                    //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                    result &= InsertSpecificFeature(nw_producto.campos_Extra.tecnologias);
                }
                //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result &= InsertExtraCamps(nw_producto.campos_Extra) & InsertProduct(nw_producto);
            }
            InsertSupplier(nvo_proveedor);
            foreach (Productos producto in nvo_proveedor.productos_que_vende)
            {
                //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result &= InsertRelation(nvo_proveedor.Id_Prov, producto.Id_productos);
            }

            return result;
        }
        //Metodo para insertar la nueva venta
        public static bool InsertarVenta(Venta venta)
        {
            bool result = true;
            using (command = new MySqlCommand("INSERT INTO Ventas values(@ID,@Fecha,@Hora,@cant,0,@total,0,1);"))
            {
                //Le damos la conecion al comando
                command.Connection = connection;
                //Le asignamos los parametros con su valor correspondiente
                command.Parameters.AddWithValue("@ID", venta.Id_venta);
                //Le asignamos los parametros con su valor correspondiente
                command.Parameters.AddWithValue("@Fecha", venta.Fecha_venta);
                //Le asignamos los parametros con su valor correspondiente
                command.Parameters.AddWithValue("@Hora", venta.Hora_Venta);
                //Le asignamos los parametros con su valor correspondiente
                command.Parameters.AddWithValue("@cant", venta.Cant_venta);
                //Le asignamos los parametros con su valor correspondiente
                command.Parameters.AddWithValue("@total", venta.Total_Venta);
                //Le decimos que prepare el comando
                command.Prepare();
                //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result &= command.ExecuteNonQuery() == 1;
            }
            return result;
        }
        //Metodo para insertar el nuevo producto que se a vendido
        public static bool InsertarProductosVentas(List<(string, int)> vendidos, string id_Venta)
        {
            bool result = true;
            //Mapeamos todos los productos vendidos
            foreach ((string, int) vendido in vendidos)
            {
                //Hacemos el ciclo de la cantida de productos vendidos
                for (int i = 0; i < vendido.Item2; i++)
                {
                    //Le damos el comando de que inserte la relacion entre los accesorios y la venta
                    using (command = new MySqlCommand("INSERT INTO accesorios value(NULL,@IdVenta,@IdProducto);"))
                    {
                        //Le damos la conecion al comando
                        command.Connection = connection;
                        //Le asignamos los parametros con su respectivo valor
                        command.Parameters.AddWithValue("@IdVenta", id_Venta);
                        //Le asignamos los parametros con su respectivo valor
                        command.Parameters.AddWithValue("@IdProducto", vendido.Item1);
                        //Le decimos que prepare la consulta
                        command.Prepare();
                        //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                        result &= command.ExecuteNonQuery() == 1;
                    }
                }
                //Realizamos el comando para que modifique la cantidad vendida del producto
                using (command = new MySqlCommand("UPDATE productos SET cantidad = cantidad - @cant WHERE id_producto = @IdProducto;"))
                {
                    //Le damos la conecion al comando
                    command.Connection = connection;
                    //Le asignamos los parametros con su respectivo valor
                    command.Parameters.AddWithValue("@cant", vendido.Item2);
                    //Le asignamos los parametros con su respectivo valor
                    command.Parameters.AddWithValue("@IdProducto", vendido.Item1);
                    //Le decimos que prepare la consulta
                    command.Prepare();
                    //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                    result &= command.ExecuteNonQuery() == 1;
                }
            }
            return result;
        }
        public static bool Actualizar_Usuario(Usuarios usuario_actualizar)
        {
            bool result = true;
            using (command = new MySqlCommand("UPDATE usuarios SET Tel_Us = @tel, correo_electronico = @correo   WHERE id_US = @ID;"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                command.Parameters.AddWithValue("@tel", usuario_actualizar.Tel_Us);
                command.Parameters.AddWithValue("@correo", usuario_actualizar.correo_electronico);
                command.Parameters.AddWithValue("@ID", usuario_actualizar.id_US);
                command.Prepare();
                result = result & command.ExecuteNonQuery() == 1;
            }
            return result;
        }
        //Metodo para actualizar los campos extra
        public static bool Actualizar_campos_extra(Campos_extra extra)
        {
            bool result = true;
            //Le damos el comando de que acutalice ciertos campos de la base de datos
            using (command = new MySqlCommand("UPDATE Campos_extra SET id_especificaciones = @spec,id_compatibilidad = @com, id_comunicacion = @comu,id_accesorios = @acc,id_tecnologias = @tec,Color = @color, Material = @material,Tamaño = @tamaño,Capacidad = @capacidad WHERE id_campos_extra = @ID"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@ID", extra.ID_campos_extra);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@spec", extra.especificacion?.Id_Ca ?? null);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@com", extra.compatibilidad?.Id_Ca ?? null);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@comu", extra.comunicacion?.Id_Ca ?? null);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@acc", extra.accesorios?.Id_Ca ?? null);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@tec", extra.tecnologias?.Id_Ca ?? null);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@color", extra.color);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@material", extra.material);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@tamaño", extra.tamaño);
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@capacidad", extra.capacida);
                //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result = result & command.ExecuteNonQuery() == 1;
            }
            return result;
        }
        //Metodo para actualizar un producto en especifico
        public static bool Actualizar_producto(Productos producto)
        {
            bool result = true;
            //Le damos el comando para que actualce el producto en especifico con ciertos campos
            using (command = new MySqlCommand("UPDATE productos SET Modelo = @modelo, Precio = @precio, Cantidad = @cantidad WHERE id_producto = @ID;"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                //Le damos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@ID", producto.Id_productos);
                //Le damos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@modelo", producto.modelo);
                //Le damos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@precio", producto.precio);
                //Le damos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@cantidad", producto.cantidad);
                command.Prepare();
                //Realizamos la consulta y si se cumplio, esta devolvera 1 y sabremos que se cumplio
                result = result & command.ExecuteNonQuery() == 1;
            }
            return result;
        }
        //Metodo para que regrese un producto en especifico con el ID
        public static Productos Return_product(string id_Product)
        {
            Productos producto = new Productos();
            //Le mandamos el comando de que lea un producto con sus especificaciones con cierto ID
            using (command = new MySqlCommand("SELECT pro.id_producto, pro.id_campos_extra, pro.tipo, pro.Modelo, pro.Precio, pro.Cantidad, es.id_especificaciones, es.Especificacion, co.id_compatibilidad, co.Compatibilidad, com.Metodo_comunicacion, com.id_comunicacion, acc.id_accesorios,  acc.Accesorios, tec.id_tecnologias, tec.Tecnologia, ex.Color, ex.Material, ex.Tamaño, ex.Capacidad, pro.stat_us FROM  productos pro INNER JOIN  campos_extra ex ON ex.id_campos_extra = pro.id_campos_extra LEFT JOIN especificaciones es ON es.id_especificaciones = ex.id_especificaciones LEFT JOIN compatibilidad co ON co.id_compatibilidad = ex.id_compatibilidad LEFT JOIN metodos_de_comunicacion com ON com.id_comunicacion = ex.id_comunicacion LEFT JOIN accesorios_productos acc ON acc.id_accesorios = ex.id_accesorios LEFT JOIN tecnologias tec ON tec.id_tecnologias = ex.id_tecnologias WHERE id_producto = @ID and stat_us = 1 LIMIT 1;"))
            {
                //Le damos la conecion al comando
                command.Connection = connection;
                //Le asignamos los parametros con su respectivo valor
                command.Parameters.AddWithValue("@ID", id_Product);
                //Le decimos que se prepare
                command.Prepare();
                //Le damos al reader para que lea la respuesta de la consulta
                using (reader = command.ExecuteReader())
                {
                    //Si el reader tiene filas
                    if (reader.HasRows)
                    {
                        //En lo que lee
                        while (reader.Read())
                        {
                            //Le pasamos la lectura al parse
                            producto = ParseTableToProducts(reader);
                        }
                    }
                }
            }
            return producto;
        }
        public static List<Productos> Return_productAll()
        {
            List<Productos> productos = new List<Productos>();
            //Le pedimos todos los productos cuyo estatus de activo sea 1
            using (command = new MySqlCommand("SELECT * FROM productos WHERE stat_us = 1;"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                command.Prepare();
                //Le decimos que ejecute el comando y se lo pase al reader el resultado
                using (reader = command.ExecuteReader())
                {
                    //Si el reader tiene filas 
                    if (reader.HasRows)
                    {
                        //Va a leer para pasarlo al metodo que hara el parseo
                        while (reader.Read())
                        {
                            productos.Add(ParseNotCompleteTableToProducts(reader));
                        }
                    }
                }
            }
            return productos;
        }

        public static List<Venta> Return_ventasAll()
        {
            List<Venta> ventas = new List<Venta>();
            //le pedimos todas las ventas cuyo estatus sea igual a 1
            using (command = new MySqlCommand("SELECT * FROM ventas WHERE stat_us = 1;"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                command.Prepare();
                //Le decimos que ejecute el comando y se lo pase al reader el resultado
                using (reader = command.ExecuteReader())
                {
                    //Si el reader tiene filas 
                    if (reader.HasRows)
                    {
                        //Va a leer para pasarlo al metodo que hara el parseo
                        while (reader.Read())
                        {
                            ventas.Add(ParseVentas(reader));
                        }
                    }
                }
            }
            return ventas;
        }
        public static List<Productos> Return_producto_from_venta(string Id_venta)
        {
            List<Productos> productos = new List<Productos>();
            // Le pedimos todos los productos de una venta en especifico
            using (command = new MySqlCommand("SELECT  pro.id_producto, pro.id_campos_extra, pro.tipo,\r\n    pro.Modelo, pro.Precio, pro.Cantidad, es.id_especificaciones, es.Especificacion, co.id_compatibilidad,\r\n    co.Compatibilidad, com.id_comunicacion, com.Metodo_comunicacion, acc.id_accesorios, acc.Accesorios,\r\n    tec.id_tecnologias, tec.Tecnologia, ex.Color, ex.Material, ex.Tamaño, ex.Capacidad, pro.stat_us \r\n\t\tFROM accesorios po INNER JOIN productos pro ON po.id_producto = pro.id_producto\r\n        INNER JOIN campos_extra ex ON ex.id_campos_extra = pro.id_campos_extra LEFT JOIN especificaciones es ON es.id_especificaciones = ex.id_especificaciones\r\n        LEFT JOIN compatibilidad co ON co.id_compatibilidad = ex.id_compatibilidad LEFT JOIN metodos_de_comunicacion com ON com.id_comunicacion = ex.id_comunicacion \r\n        LEFT JOIN accesorios_productos acc ON acc.id_accesorios = ex.id_accesorios LEFT JOIN tecnologias tec ON tec.id_tecnologias = ex.id_tecnologias WHERE Id_venta = @ID;"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                command.Parameters.AddWithValue("@ID", Id_venta);
                command.Prepare();
                //Le decimos que ejecute el comando y se lo pase al reader el resultado
                using (reader = command.ExecuteReader())
                {
                    //Si el reader tiene filas 
                    if (reader.HasRows)
                    {
                        //Va a leer para pasarlo al metodo que hara el parseo
                        while (reader.Read())
                        {
                            productos.Add(ParseTableToProducts(reader));
                        }
                    }
                }
            }
            return productos;
        }
        public static Usuarios Return_User(string id_User)
        {
            Usuarios usuario = new Usuarios();
            //Le pedimos todos los usuarios que tengan un estatus activo
            using (command = new MySqlCommand("select * from usuarios where id_US = @ID and stat_us = 1 LIMIT 1;"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                command.Parameters.AddWithValue("@ID", id_User);
                command.Prepare();
                //Le decimos que ejecute el comando y se lo pase al reader el resultado
                using (reader = command.ExecuteReader())
                {
                    //Si el reader tiene filas 
                    if (reader.HasRows)
                    {
                        //Va a leer para pasarlo al metodo que hara el parseo
                        while (reader.Read())
                        {
                            usuario = ParseTableToUser(reader);
                        };
                    }
                }
            }
            return usuario;
        }
        public static Proveedor Return_Supplier(string id_Prov)
        {
            Proveedor proveedor = new Proveedor();
            //Le pedimos que nos devuelva un proveedor en especial y que el status este activo
            using (command = new MySqlCommand("SELECT * FROM proveedor WHERE stat_us = 1 AND Id_Prov = @ID ;"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                command.Parameters.AddWithValue("@ID", id_Prov);
                command.Prepare();
                //Le decimos que ejecute el comando y se lo pase al reader el resultado
                using (reader = command.ExecuteReader())
                {
                    //Si el reader tiene filas 
                    if (reader.HasRows)
                    {
                        //Va a leer para pasarlo al metodo que hara el parseo
                        while (reader.Read())
                        {
                            proveedor = ParseTableToSupplier(reader);
                        }
                    }
                }
            }
            return proveedor;
        }
        public static List<Productos> SeeAllProducts()
        {
            List<Productos> productos = new List<Productos>();
            //Le pedimos que seleccione todos los productos activos
            using (command = new MySqlCommand("SELECT pro.id_producto, pro.id_campos_extra, pro.tipo, pro.Modelo, pro.Precio, pro.Cantidad, es.id_especificaciones, es.Especificacion, co.id_compatibilidad, co.Compatibilidad, com.Metodo_comunicacion, com.id_comunicacion, acc.id_accesorios,  acc.Accesorios, tec.id_tecnologias, tec.Tecnologia, ex.Color, ex.Material, ex.Tamaño, ex.Capacidad, pro.stat_us FROM  productos pro INNER JOIN  campos_extra ex ON ex.id_campos_extra = pro.id_campos_extra LEFT JOIN especificaciones es ON es.id_especificaciones = ex.id_especificaciones LEFT JOIN compatibilidad co ON co.id_compatibilidad = ex.id_compatibilidad LEFT JOIN metodos_de_comunicacion com ON com.id_comunicacion = ex.id_comunicacion LEFT JOIN accesorios_productos acc ON acc.id_accesorios = ex.id_accesorios LEFT JOIN tecnologias tec ON tec.id_tecnologias = ex.id_tecnologias;"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                //Le decimos que ejecute el comando y se lo pase al reader el resultado
                using (reader = command.ExecuteReader())
                {
                    //Si el reader tiene filas 
                    if (reader.HasRows)
                    {
                        //Va a leer para pasarlo al metodo que hara el parseo
                        while (reader.Read())
                        {
                            productos.Add(ParseTableToProducts(reader));
                        }
                    }
                }
            }
            return productos;
        }
        public static List<Caracteristica_especifica> SeeAllSpecs(TypeExtra extra)
        {
            List<Caracteristica_especifica> caracteristicas = new List<Caracteristica_especifica>();
            string table = string.Empty;
            switch (extra)
            {
                case TypeExtra.COMPATIBILIDAD:
                    table = "Compatibilidad";
                    break;
                case TypeExtra.ACCESORIOS:
                    table = "Accesorios_productos";
                    break;
                case TypeExtra.ESPECIFICACIONES:
                    table = "Especificaciones";
                    break;
                case TypeExtra.TECNOLOGIAS:
                    table = "Tecnologias";
                    break;
                case TypeExtra.METODOS_DE_COMUNICACION:
                    table = "Metodos_de_comunicacion";
                    break;
            }
            //Le pedimos que selececione la caraceristica en especifico
            using (command = new MySqlCommand(String.Format("SELECT * FROM {0};", table)))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                //Le decimos que ejecute el comando y se lo pase al reader el resultado
                using (reader = command.ExecuteReader())
                {
                    //Si el reader tiene filas 
                    if (reader.HasRows)
                    {
                        //Va a leer para pasarlo al metodo que hara el parseo
                        while (reader.Read())
                        {
                            caracteristicas.Add(ParseTableToSpec(reader, extra));
                        }
                    }
                }
            }
            return caracteristicas;
        }
        public static List<Usuarios> SeeAllEmployee()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            //Le pedimos que muestre todos los empleados
            using (command = new MySqlCommand("SELECT * FROM usuarios WHERE stat_us = 1 AND tipo_usuario = 1;"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                //Le decimos que ejecute el comando y se lo pase al reader el resultado
                using (reader = command.ExecuteReader())
                {
                    //Si el reader tiene filas 
                    if (reader.HasRows)
                    {
                        //Va a leer para pasarlo al metodo que hara el parseo
                        while (reader.Read())
                        {
                            Usuarios usuario = ParseTableToUser(reader);
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            return usuarios;
        }
        public static List<Proveedor> SeeAllSupplier()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            //Le pedimos que muestre todos los proveedores
            using (command = new MySqlCommand("SELECT * FROM proveedor WHERE stat_us = 1 ;"))
            {
                //Le damos la conexion al comando
                command.Connection = connection;
                //Le decimos que ejecute el comando y se lo pase al reader el resultado
                using (reader = command.ExecuteReader())
                {
                    //Si el reader tiene filas 
                    if (reader.HasRows)
                    {
                        //Va a leer para pasarlo al metodo que hara el parseo
                        while (reader.Read())
                        {
                            proveedores.Add(ParseTableToSupplier(reader));
                        }
                    }
                }
            }
            foreach (Proveedor proveedor in proveedores)
            {
                //Y por cada proveedor seleccionamos los productos que es que vende
                using (command = new MySqlCommand("SELECT  pro.id_producto, pro.id_campos_extra, pro.tipo,\r\n    pro.Modelo, pro.Precio, pro.Cantidad, es.id_especificaciones, es.Especificacion, co.id_compatibilidad,\r\n    co.Compatibilidad, com.id_comunicacion, com.Metodo_comunicacion, acc.id_accesorios, acc.Accesorios,\r\n    tec.id_tecnologias, tec.Tecnologia, ex.Color, ex.Material, ex.Tamaño, ex.Capacidad, pro.stat_us \r\n\t\tFROM productos_a_vender po INNER JOIN productos pro ON po.id_producto = pro.id_producto\r\n        INNER JOIN campos_extra ex ON ex.id_campos_extra = pro.id_campos_extra LEFT JOIN especificaciones es ON es.id_especificaciones = ex.id_especificaciones\r\n        LEFT JOIN compatibilidad co ON co.id_compatibilidad = ex.id_compatibilidad LEFT JOIN metodos_de_comunicacion com ON com.id_comunicacion = ex.id_comunicacion \r\n        LEFT JOIN accesorios_productos acc ON acc.id_accesorios = ex.id_accesorios LEFT JOIN tecnologias tec ON tec.id_tecnologias = ex.id_tecnologias WHERE Id_Prov = @ID;"))
                {
                    //Le damos la conexion al comando
                    command.Connection = connection;
                    //LE pasamos el parametro con su respectivo proveedor
                    command.Parameters.AddWithValue("@ID", proveedor.Id_Prov);
                    command.Prepare();
                    //Le decimos que ejecute el comando y se lo pase al reader el resultado
                    using (reader = command.ExecuteReader())
                    {
                        //Si el reader tiene filas 
                        if (reader.HasRows)
                        {
                            //Va a leer para pasarlo al metodo que hara el parseo
                            while (reader.Read())
                            {
                                proveedor.productos_que_vende.Add(ParseTableToProducts(reader));
                            }
                        }
                    }
                }
            }
            return proveedores;
        }
    }
}

