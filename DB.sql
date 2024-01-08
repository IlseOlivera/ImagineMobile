DROP database IF EXISTS IMAGINE_MOBILE_DB;
/*Base de datos para el proyecto Imagine Mobile*/
/*Primero creamos la base de datos si es que no existe*/
CREATE database IF NOT EXISTS  IMAGINE_MOBILE_DB;
/*Usamos esa base de datos*/
use IMAGINE_MOBILE_DB;
/*Creamos la primera tabla*/
CREATE TABLE IF NOT EXISTS Usuarios(
/*Creamos el id usuario como varchar llave primaria y unica*/
id_US varchar(10) Not null primary key unique,
/*Nombre del usuario*/
Nom_US varchar(20) not null,
/*Apellido del usuario*/
Ap_US varchar(15) not null,
/*Apellido materno del usuario*/
Am_US varchar(15) not null,
/*RFC del cliente*/
rfc_Us varchar(13) not null unique,
/*CURP del cliente*/
curp_US varchar(18) not null unique,
/*Seguro social del cliente*/
nss_Us  varchar(11) not null unique,
/*Telefono del cliente*/
Tel_Us numeric(25) not null,
/*Correo del cliente*/
correo_electronico varchar(30) NOT NULL,
/*Fecha de nacimiento*/
fchNac_Us DATE NOT NULL,
/*Fecha de registro*/
fching_Us DATE NOT NULL,
/*Que tipo de usuario es*/
tipo_usuario binary(1) NOT NULL,
/*Estatus del campo*/
stat_us binary(1) NOT NULL,
/*Realiza una revision de si es que el id cumple con el patron*/
check (id_US regexp '^ADM|EMP[A-Z]{2}\\d{4}$'),
check(rfc_US regexp '^\\w{4}\\d{6}\\w{3}$'),
check(correo_electronico regexp '^(\\w{1,64})@(\\w{1,255})\\.com$')
); 
/*Tabla que guarda los accesorios*/
CREATE TABLE IF NOT EXISTS Accesorios_productos(
/*Id de los accesorios que se han registrado*/
id_accesorios varchar(10) NOT NULL UNIQUE PRIMARY KEY,
/*accesorios registrados*/
Accesorios varchar(30) NOT NULL,
/*Realiza una revision de si es que el id cumple con el patron*/
check(id_accesorios regexp '^ACCP[A-Z]{2}\\d{4}$')
);
/*Taba que guarda las tecnologias*/
CREATE TABLE IF NOT exists Tecnologias(
/*Id de las tecnologias que se han registrado*/
id_tecnologias varchar(10) NOT NULL UNIQUE PRIMARY KEY,
/*Tecnologias registradas*/
Tecnologia varchar(30) NOT NULL,
/*Realiza una revision de si es que el id cumple con el patron*/
check(id_tecnologias regexp '^TECN[A-Z]{2}\\d{4}$') 
);
/*Tabla que guarda las especificaciones*/
CREATE TABLE IF NOT exists Especificaciones(
/*Id de las especificaciones registradas*/
id_especificaciones varchar(10) NOT NULL UNIQUE PRIMARY KEY,
/*Especificaciones registradas*/
Especificacion varchar(30) NOT NULL,
/*Realiza una revision de si es que el id cumple con el patron*/
check(id_especificaciones regexp '^SPEC[A-Z]{2}\\d{4}$') 
);
/*Tabla que guarda todas las compatibilidades*/
CREATE TABLE IF NOT EXISTS Compatibilidad(
/*Id de las compatibilidades registradas*/
id_compatibilidad varchar(10) NOT NULL UNIQUE PRIMARY KEY,
/*Compatibilidad registrada*/
Compatibilidad varchar(30),
/*Realiza una revision de si es que el id cumple con el patron*/
check(id_compatibilidad regexp '^COMP[A-Z]{2}\\d{4}$') 
);
/*Tabla que guarda los metodos de comunicacion*/
CREATE TABLE IF NOT EXISTS Metodos_de_comunicacion(
/*ID que guarda todos los metodos de comunicacion almacenados*/
id_comunicacion varchar(10)  NOT null UNIQUE PRIMARY KEY,
/*Metodos de comunicacion guardados*/
Metodo_comunicacion varchar(30) NOT NULL,
/*Realiza una revision de si es que el id cumple con el patron*/
check(id_comunicacion regexp '^COMU[A-Z]{2}\\d{4}$') 
);
/*Tabla que guarda los campos extra de un producto*/
CREATE TABLE IF NOT EXISTS Campos_extra(
/*Id de los campos extra*/
id_campos_extra varchar(12) NOT NULL UNIQUE PRIMARY KEY,
/*Todas las especificaciones que tiene un producto*/
id_especificaciones varchar(10) NULL ,
/*La compatibilidad con la que cuenta un producto*/
id_compatibilidad varchar(10) NULL ,
/*Los medios de comunicacion que utiliza*/
id_comunicacion varchar(10)  NULL ,
/*accesorios con los que cuenta*/
id_accesorios varchar(10) NULL ,
/*Tecnologias con las que cuenta*/
id_tecnologias varchar(10) NULL ,
/*Color del producto*/
Color varchar(15) NULL,
/*Material del que esta hecho*/
Material varchar(20) NULL,
/*Tamño del producto*/
Tamaño varchar(20) NULL,
/*Capacidad de memoria*/
Capacidad numeric(15) NULL,
/*Relacion de la llave foranea entre los extra y las especificaciones*/
constraint FK_campos_especificaciones
foreign key (id_especificaciones) 
references Especificaciones(id_especificaciones),
/*Relacion de la llave foranea entre los campos y la compatibilidad*/
constraint FK_campos_compatibilidad 
foreign key (id_compatibilidad)
references Compatibilidad(id_compatibilidad),
/*Relacion de la llave foranea entre los campos y la comunicacion*/
constraint FK_campos_comunicacion 
foreign key (id_comunicacion)
references Metodos_de_comunicacion(id_comunicacion),
/*Relacion de la llave foranea entre los campos y accesorios*/
constraint FK_campos_accesorios
foreign key (id_accesorios)
references Accesorios_productos(id_accesorios),
/*Relacion de la llave foranea de los campos y las tecnologias*/
constraint FK_campos_tecnologias
foreign key (id_tecnologias)
references Tecnologias(id_tecnologias),
/*Realiza una revision de si es que el id cumple con el patron*/
check(id_campos_extra regexp '^CAMEX[A-Z]{3}\\d{4}$'),
check(id_accesorios regexp '^ACCP[A-Z]{2}\\d{4}$'),
check(id_tecnologias regexp '^TECN[A-Z]{2}\\d{4}$'),
check(id_especificaciones regexp '^SPEC[A-Z]{2}\\d{4}$'), 
check(id_compatibilidad regexp '^COMP[A-Z]{2}\\d{4}$'),
check(id_comunicacion regexp '^COMU[A-Z]{2}\\d{4}$'),
check(Capacidad > 0)
);
/*Tabla donde se almacenan los productos*/
CREATE TABLE IF NOT EXISTS Productos(
/*id del producto almacenado*/
id_producto varchar(10) NOT NULL UNIQUE PRIMARY KEY,
/*llave foranea para los campos extra*/
id_campos_extra varchar(12) NOT NULL UNIQUE,
/*El tipo de dato que es el poducto*/
tipo bit(4) NOT NULL,
/*Numero de modelo del producto*/
Modelo numeric(10) NOT NULL,
/*El precio del producto*/
Precio numeric(6) NOT NULL,
/*La cantidad almacenada*/
Cantidad numeric(4) NOT NULL,
/*El estatus de si esta activo o no*/
stat_us binary(1) NOT NULL,
/*Relacion de la llave foranea entre los productos y sus campos*/
constraint FK_productos_campos
foreign key (id_campos_extra)
references Campos_extra(id_campos_extra),
/*Realiza una revision de si es que el id cumple con el patron*/
check(id_producto regexp '^(MICA|PROT|AUD|BOC|CARG|MOUS|TECLA|MONI|CHIP|MEMO|REC|TEL)([A-Z]{3,4})(\\d{2,3})$'),
check(id_campos_extra regexp '^CAMEX[A-Z]{3}\\d{4}$'),
check(Modelo > 0),
check(Precio > 0),
check(Cantidad >= 0)
);
/*Tabla de las ventas a realizar*/
CREATE TABLE IF NOT EXISTS Ventas(
 /*id de la venta a realizar*/
 Id_venta varchar(12) NOT NULL UNIQUE PRIMARY KEY,
 /*fecha que se realizo la venta*/
 Fecha_venta date NOT NULL,
 /*Hora que se realizo la venta*/
 Hora_Venta time NOT NULL,
 /*Cantidad de lo que se vendio*/
 Cant_venta numeric(3) NOT NULL,
 /*Precio de cada producto??*/
 Precio_Venta numeric(5) NOT NULL,
 /*Total de lo que se vendio*/
 Total_Venta numeric(6) NOT NULL,
 /*El tipo de pago que se va a realizar*/
 Pago_venta bit(1) NOT NULL,
 /*El estatus de si esta activo o no*/
 stat_us binary(1) NOT NULL,
 /*Realiza una revision de si es que el id cumple con el patron*/
 check(Id_venta regexp '^(2\d{3})(0?[1-9]|1[1-2]{2})(3[01]|[12][0-9]|(0?[1-9]){1,2})([0-9]{4})$'),
 /*Revisando que sean correcto los datos*/
 check(Cant_venta > 0),
 check(Total_Venta > 0)
);
/*Tabla de relacion entre los accesorios que se venden*/
CREATE TABLE IF NOT EXISTS Accesorios(
	/*Conteo de los productos a vender*/
    id_accesorios BIGINT(255) UNSIGNED NOT NULL PRIMARY KEY AUTO_INCREMENT,
	/*id de los accesoios a vender*/
	Id_venta varchar(12) NOT NULL,
   /*id del producto a vender*/
   id_producto varchar(10) NOT NULL,
   /*Relacion entre los accesorios y los productos*/
    constraint FK_accesorios_productos
    foreign key (id_producto)
    references Productos(id_producto), 
    /*La relacion entre los productos y sus accesorios*/
	constraint FK_productos_ventas
	foreign key (Id_venta)
	references Ventas(Id_venta),
    /*Realiza una revision de si es que el id cumple con el patron*/
   check(id_producto regexp '^(MICA|PROT|AUD|BOC|CARG|MOUS|TECLA|MONI|CHIP|MEMO|REC|TEL)([A-Z]{4})(\\d{2,3})$')
);
/*Tabla para alamcenar toods los proveedores*/
CREATE TABLE IF NOT EXISTS Proveedor (
	/*Id para almacenar el proveedor*/
    Id_Prov VARCHAR(10) NOT NULL UNIQUE PRIMARY KEY,
    /*RFC del proveedor*/
    rfc_Prov VARCHAR(13) NOT NULL,
    /*Nombre del proveedor*/
    Nom_Prov VARCHAR(25) NOT NULL,
    /*Representante o nombre del repredsentante del proveedor*/
    Rep_prov VARCHAR(35) NULL,
    /*Direccion del proveedor*/
    Dir_prov VARCHAR(360) NOT NULL,
    /*Correo del proveedor*/
    Correo_prov VARCHAR(25) NOT NULL,
    /*Numero de telefono del proveerdor*/
    Num_Prov VARCHAR(30) NOT NULL,
    /*El estatus de si esta activo o no*/
    stat_us BINARY(1) NOT NULL,
    /*Realiza una revision de si es que el id cumple con el patron*/
    check (Id_Prov regexp '^PROV([A-Z]{2})+(\\d{4})+$'),
    check(rfc_Prov regexp '^\\w{4}\\d{6}\\w{3}$'),
    check(Correo_prov regexp '^(\\w{1,64})@(\\w{1,255})\\.com$')
);
/*Tabla para almacenar todos los productos que un proveedor vende*/
CREATE TABLE IF NOT EXISTS productos_a_vender(
	/*Conteo de los productos a vender*/
    id_productos_vender BIGINT(255) UNSIGNED NOT NULL PRIMARY KEY AUTO_INCREMENT,
	/*el id del los producto que vende*/
	 Id_Prov varchar(10) NOT NULL,
    /*el id del producto que vende*/
    id_producto varchar(10) NOT NULL,
    /*Relacuon entre los productos del proveedor y los productos a vender*/
    constraint FK_proveedor_productos
    foreign key (id_producto)
    references Productos(id_producto),
    /*Relacion del proveedor y sus productos a vender*/
    CONSTRAINT FK_productos_a_vender_proveedor
    FOREIGN KEY (Id_Prov)
	REFERENCES Proveedor(Id_Prov),
    /*Realiza una revision de si es que el id cumple con el patron*/
    check(id_producto regexp '^(MICA|PROT|AUD|BOC|CARG|MOUS|TECLA|MONI|CHIP|MEMO|REC|TEL)([A-Z]{4})(\\d{2,3})$')
);
