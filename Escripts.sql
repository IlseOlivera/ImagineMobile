use IMAGINE_MOBILE_DB;

DROP ROLE ADMINISTRADOR;
DROP ROLE EMPLEADO;
/*Creamos roles para la administracion de la base de datos*/
CREATE ROLE ADMINISTRADOR;
CREATE ROLE EMPLEADO;

/*Les damos privilegios sobre la base de datos*/
      /*Select, insert,...*/
GRANT SELECT, INSERT,UPDATE,DELETE,REFERENCES,ALTER ON imagine_mobile_db.* to ADMINISTRADOR; 
GRANT SHOW DATABASES, CREATE USER, SUPER on *.* to ADMINISTRADOR WITH GRANT OPTION;
GRANT SELECT ON imagine_mobile_db.usuarios to EMPLEADO;
GRANT INSERT, UPDATE, SELECT ON imagine_mobile_db.proveedor to EMPLEADO;
GRANT INSERT, UPDATE, SELECT  ON imagine_mobile_db.productos_a_vender to EMPLEADO;
GRANT INSERT, UPDATE, SELECT  ON imagine_mobile_db.productos to EMPLEADO;
GRANT INSERT, UPDATE, SELECT  ON imagine_mobile_db.campos_extra to EMPLEADO;
GRANT INSERT, UPDATE, SELECT  ON imagine_mobile_db.accesorios to EMPLEADO;
GRANT INSERT, UPDATE, SELECT  ON imagine_mobile_db.accesorios_productos to EMPLEADO ;
GRANT INSERT, UPDATE, SELECT  ON imagine_mobile_db.accesorios to EMPLEADO;
GRANT INSERT, UPDATE, SELECT  ON imagine_mobile_db.tecnologias to EMPLEADO;
GRANT INSERT, UPDATE, SELECT  ON imagine_mobile_db.compatibilidad to EMPLEADO;
GRANT INSERT, UPDATE, SELECT  ON imagine_mobile_db.especificaciones to EMPLEADO;
GRANT INSERT, UPDATE, SELECT  ON imagine_mobile_db.metodos_de_comunicacion to EMPLEADO;
GRANT INSERT, UPDATE, SELECT ON imagine_mobile_db.ventas to EMPLEADO;
GRANT SHOW DATABASES on *.* to EMPLEADO;
/*Dropeando usuarios*/
DROP USER 'ADMIN'@'localhost';
DROP USER 'Daniel2'@'localhost';
/*DROP USER 'Juanito'@'localhost';
/*Creamos los usuarios que van dentro de la base de datos*/
INSERT into usuarios values ('ADMAA0001','ADMIN','ADMIN','ADMIN','GOMD020226HNF','GOMD020226HDFTRNA5','11111111111',5527699768,'danielmtzlpz95@gmail.com',DATE('2002-02-26'),curdate(),0,1);
INSERT into usuarios values ('EMPAA0002','Daniel2','González','Martínez','GOMD020226HDF','GOMD020226HDFNRNA5','11111111112',5527689768,'danielmtzlpz95@gmail.com',DATE('2002-02-26'),curdate(),1,1);
SELECT * FROM usuarios WHERE stat_us = 1 AND tipo_usuario = 1;
/*UPDATE usuarios 
SET 
    fching_Us = 'pedrito'
WHERE
    id_US = 'EMPHV6872'; 

select * from usuarios where id_US = 'EMPHV6872' and stat_us = 1 LIMIT 1;
Delete from usuarios where id_US = 'EMPJT0548';*/
/*Damos de alta los usuarios en la base de datos con la contraseña*/

CREATE user 'ADMIN'@'localhost' IDENTIFIED by '123';
CREATE user 'Daniel2'@'localhost' IDENTIFIED by '456';

/*SHOW GRANTS for 'ADMIN'@'localhost';
SELECT current_role();*/

GRANT ADMINISTRADOR to 'ADMIN'@'localhost';
GRANT EMPLEADO to 'Daniel2'@'localhost';
SET ROLE ALL;
/***/
/*SELECT 
    id_US
FROM
    usuarios
WHERE
    Nom_US = 'Daniel2' AND stat_us = 1
LIMIT 1;*/
/*Ver los usuarios*/
select * from mysql.user;
/*Insertamos accesorios*/
INSERT INTO Accesorios_productos values ("ACCPAA0001","Jack de audio macho 3.5");
INSERT INTO Accesorios_productos values ("ACCPAA0002","Cargador lightninig");
INSERT INTO Accesorios_productos values ("ACCPAA0003","Cargador Puerto C");
INSERT INTO Accesorios_productos values ("ACCPAA0004","Cable USB 3.1");
SELECT CASE WHEN EXISTS (
    SELECT 1
    FROM Accesorios_productos
    WHERE id_accesorios = 'ACCPAA0001'
    ) THEN 1 ELSE 0 END AS existe_campo;
/*INSERT INTO Accesorios_productos values ("ACCPAA0005","Cargador Puerto C");*/
Select * from Accesorios_productos;
/*Insertamos tecnologias*/
INSERT INTO Tecnologias values("TECNAA0001","WI-FI 6");
INSERT INTO Tecnologias values("TECNAA0002","Bluetooth 5.3");
INSERT INTO Tecnologias values("TECNAA0003","Fast charge de samsung");
INSERT INTO Tecnologias values("TECNAA0004","Teclas mecanicas RED cherry");
INSERT INTO Tecnologias values("TECNAA0005","Sensor optico");
INSERT INTO Tecnologias values("TECNAA0006","Proteccion de keblar");
Select * from Tecnologias;
/*Insertamos Especificaciones*/
INSERT INTO Especificaciones values("SPECAA0001","Pantalla OLED de 3 pulgadas");
INSERT INTO Especificaciones values("SPECAA0002","Teclado de membrana");
INSERT INTO Especificaciones values("SPECAA0003","Puerto de entrada NVME");
INSERT INTO Especificaciones values("SPECAA0004","Mouse de millon de pulsaciones");
INSERT INTO Especificaciones values("SPECAA0005","Audio 5.0");
Select * from Especificaciones;
/*Compatibilidad*/
INSERT INTO Compatibilidad values("COMPAA0001","Wi-Fi 1");
INSERT INTO Compatibilidad values("COMPAA0002","USB 2.1");
INSERT INTO Compatibilidad values("COMPAA0003","bluethooth 3");
INSERT INTO Compatibilidad values("COMPAA0004","Puertos SATA");
INSERT INTO Compatibilidad values("COMPAA0005","Hasta iphone 13");
Select * from compatibilidad;
/*Insertando metodos de comunicacion*/
INSERT INTO Metodos_de_comunicacion values('COMUAA0001',"Jack 3.5");
INSERT INTO Metodos_de_comunicacion values('COMUAA0002',"Bluetooth 5.3");
INSERT INTO Metodos_de_comunicacion values('COMUAA0003',"Wi-Fi 5G");
INSERT INTO Metodos_de_comunicacion values('COMUAA0004',"USB C");
INSERT INTO Metodos_de_comunicacion values('COMUAA0005',"USB 3.1");
Select * from metodos_de_comunicacion;
/*Insertamos 3 productos*/
/*carcasa para iphone*/
INSERT INTO Campos_extra values('CAMEXAAA0001',NULL,'COMPAA0005',NULL,'ACCPAA0001','TECNAA0006','Red','Aluminio','14,65.7,15',NULL);
/*Audifono Bose*/
INSERT INTO Campos_extra values('CAMEXAAA0002','SPECAA0005','COMPAA0003','COMUAA0002','ACCPAA0003','TECNAA0002','Black','Plastico','39,1.25,9.26,9',NULL);
/*Mouse razer*/
INSERT INTO Campos_extra values('CAMEXAAA0003','SPECAA0004','COMPAA0003','COMUAA0005','ACCPAA0004','TECNAA0005','Black','Plastico','119,6.62,5.38,1',NULL);
/*Ejemplos para la tarjeta*/
/*carcasa para iphone*/
INSERT INTO Campos_extra values('CAMEXAAA0004',NULL,'COMPAA0005',NULL,'ACCPAA0001','TECNAA0006','Red','Aluminio','14,65.7,15',NULL);
/*Audifono Bose*/
INSERT INTO Campos_extra values('CAMEXAAA0005','SPECAA0005','COMPAA0003','COMUAA0002','ACCPAA0003','TECNAA0002','Black','Plastico','39,1.25,9.26,9',NULL);
/*Mouse razer*/
INSERT INTO Campos_extra values('CAMEXAAA0006','SPECAA0004','COMPAA0003','COMUAA0005','ACCPAA0004','TECNAA0005','Black','Plastico','119,6.62,5.38,1',NULL);
/*carcasa para iphone*/
INSERT INTO Campos_extra values('CAMEXAAA0007',NULL,'COMPAA0005',NULL,'ACCPAA0001','TECNAA0006','Red','Aluminio','14,65.7,15',NULL);
/*Audifono Bose*/
INSERT INTO Campos_extra values('CAMEXAAA0008','SPECAA0005','COMPAA0003','COMUAA0002','ACCPAA0003','TECNAA0002','Black','Plastico','39,1.25,9.26,9',NULL);
/*Mouse razer*/
INSERT INTO Campos_extra values('CAMEXAAA0009','SPECAA0004','COMPAA0003','COMUAA0005','ACCPAA0004','TECNAA0005','Black','Plastico','119,6.62,5.38,1',NULL);
/*carcasa para iphone*/
INSERT INTO Campos_extra values('CAMEXAAA0010',NULL,'COMPAA0005',NULL,'ACCPAA0001','TECNAA0006','Red','Aluminio','14,65.7,15',NULL);
/*Audifono Bose*/
INSERT INTO Campos_extra values('CAMEXAAA0011','SPECAA0005','COMPAA0003','COMUAA0002','ACCPAA0003','TECNAA0002','Black','Plastico','39,1.25,9.26,9',NULL);
/*Mouse razer*/
INSERT INTO Campos_extra values('CAMEXAAA0012','SPECAA0004','COMPAA0003','COMUAA0005','ACCPAA0004','TECNAA0005','Black','Plastico','119,6.62,5.38,1',NULL);
/*carcasa para iphone*/
INSERT INTO Campos_extra values('CAMEXAAA0013',NULL,'COMPAA0005',NULL,'ACCPAA0001','TECNAA0006','Red','Aluminio','14,65.7,15',NULL);
/*Audifono Bose*/
INSERT INTO Campos_extra values('CAMEXAAA0014','SPECAA0005','COMPAA0003','COMUAA0002','ACCPAA0003','TECNAA0002','Black','Plastico','39,1.25,9.26,9',NULL);
/*Mouse razer*/
INSERT INTO Campos_extra values('CAMEXAAA0015','SPECAA0004','COMPAA0003','COMUAA0005','ACCPAA0004','TECNAA0005','Black','Plastico','119,6.62,5.38,1',NULL);

Select * from campos_extra;

SELECT 
    ex.id_campos_extra,
    es.Especificacion,
    co.Compatibilidad,
    com.Metodo_comunicacion,
    acc.Accesorios,
    ex.Color,
    ex.Material,
    ex.Tamaño,
    ex.Capacidad
FROM
    campos_extra ex
        LEFT JOIN
    especificaciones es ON  es.id_especificaciones = ex.id_especificaciones
        LEFT JOIN
    compatibilidad co ON co.id_compatibilidad =  ex.id_compatibilidad 
        LEFT JOIN
    metodos_de_comunicacion com ON  com.id_comunicacion = ex.id_comunicacion
        LEFT JOIN
    accesorios_productos acc ON  acc.id_accesorios = ex.id_accesorios
        LEFT JOIN
    tecnologias tec ON tec.id_tecnologias = ex.id_tecnologias;
/*Insertamos productos*/
/*Carcasa para iphone*/
INSERT INTO Productos values('PROTAAAA01','CAMEXAAA0001',2,1111111111,500,100,1);
/*Audifonos Bose*/
INSERT INTO Productos values('AUDAAAA001','CAMEXAAA0002',3,1111111112,800,5000,1);
/*Mouse razer*/
INSERT INTO Productos values('MOUSAAAA01','CAMEXAAA0003',6,1111111113,1200,3000,1);
/*Carcasa para iphone*/
INSERT INTO Productos values('PROTAAAA02','CAMEXAAA0004',2,1111111114,500,100,1);
/*Audifonos Bose*/
INSERT INTO Productos values('AUDAAAA002','CAMEXAAA0005',3,1111111115,800,5000,1);
/*Mouse razer*/
INSERT INTO Productos values('MOUSAAAA02','CAMEXAAA0006',6,1111111116,1200,3000,1);
/*Carcasa para iphone*/
INSERT INTO Productos values('PROTAAAA03','CAMEXAAA0007',2,1111111117,500,100,1);
/*Audifonos Bose*/
INSERT INTO Productos values('AUDAAAA003','CAMEXAAA0008',3,1111111118,800,5000,1);
/*Mouse razer*/
INSERT INTO Productos values('MOUSAAAA03','CAMEXAAA0009',6,1111111119,1200,3000,1);
/*Carcasa para iphone*/
INSERT INTO Productos values('PROTAAAA04','CAMEXAAA0010',2,1111111110,500,100,1);
/*Audifonos Bose*/
INSERT INTO Productos values('AUDAAAA004','CAMEXAAA0011',3,1111111111,800,5000,1);
/*Mouse razer*/
INSERT INTO Productos values('MOUSAAAA04','CAMEXAAA0012',6,1111111112,1200,3000,1);
/*Carcasa para iphone*/
INSERT INTO Productos values('PROTAAAA05','CAMEXAAA0013',2,1111111113,500,100,1);
/*Audifonos Bose*/
INSERT INTO Productos values('AUDAAAA005','CAMEXAAA0014',3,1111111114,800,5000,1);
/*Mouse razer*/
INSERT INTO Productos values('MOUSAAAA06','CAMEXAAA0015',6,1111111115,1200,3000,1);
select id_producto, modelo,tipo from productos where stat_us = 1;
SELECT 
	pro.id_producto,
    pro.tipo,
    pro.Modelo,
    pro.Precio,
    pro.Cantidad,
    es.Especificacion,
    co.Compatibilidad,
    com.Metodo_comunicacion,
    acc.Accesorios,
    ex.Color,
    ex.Material,
    ex.Tamaño,
    ex.Capacidad,
    pro.stat_us
FROM
    productos pro
        INNER JOIN
    campos_extra ex ON ex.id_campos_extra = pro.id_campos_extra
        LEFT JOIN
    especificaciones es ON es.id_especificaciones = ex.id_especificaciones
        LEFT JOIN
    compatibilidad co ON co.id_compatibilidad = ex.id_compatibilidad
        LEFT JOIN
    metodos_de_comunicacion com ON com.id_comunicacion = ex.id_comunicacion
        LEFT JOIN
    accesorios_productos acc ON acc.id_accesorios = ex.id_accesorios
        LEFT JOIN
    tecnologias tec ON tec.id_tecnologias = ex.id_tecnologias;
    
    SELECT 
    pro.id_producto,
    pro.id_campos_extra,
    pro.tipo,
    pro.Modelo,
    pro.Precio,
    pro.Cantidad,
    es.id_especificaciones,
    es.Especificacion,
    co.id_compatibilidad,
    co.Compatibilidad,
    com.id_comunicacion,
    com.Metodo_comunicacion,
    acc.id_accesorios,
    acc.Accesorios,
    tec.id_tecnologias,
    tec.Tecnologia,
    ex.Color,
    ex.Material,
    ex.Tamaño,
    ex.Capacidad,
    pro.stat_us
FROM
    productos pro
        INNER JOIN
    campos_extra ex ON ex.id_campos_extra = pro.id_campos_extra
        LEFT JOIN
    especificaciones es ON es.id_especificaciones = ex.id_especificaciones
        LEFT JOIN
    compatibilidad co ON co.id_compatibilidad = ex.id_compatibilidad
        LEFT JOIN
    metodos_de_comunicacion com ON com.id_comunicacion = ex.id_comunicacion
        LEFT JOIN
    accesorios_productos acc ON acc.id_accesorios = ex.id_accesorios
        LEFT JOIN
    tecnologias tec ON tec.id_tecnologias = ex.id_tecnologias;

    /*Insertamos Ventas*/
	INSERT INTO Ventas values("202312290001",curdate(),DATE_FORMAT(NOW( ), "%H:%i:%S" ),5,0,11400,0,1);
	INSERT INTO Ventas values("202312290002",curdate(),DATE_FORMAT(NOW( ), "%H:%i:%S" ),1,0,5000,1,1);
	INSERT INTO Ventas values("202312290003",curdate(),DATE_FORMAT(NOW( ), "%H:%i:%S" ),2,0,3100,0,1);

    Select * from Ventas;
    
INSERT INTO accesorios value(NULL,"202312290001","PROTAAAA01");
INSERT INTO accesorios value(NULL,"202312290001","PROTAAAA01");
INSERT INTO accesorios value(NULL,"202312290001","AUDAAAA001");
INSERT INTO accesorios value(NULL,"202312290001","AUDAAAA001");
INSERT INTO accesorios value(NULL,"202312290001","MOUSAAAA01");
INSERT INTO accesorios value(NULL,"202312290002","AUDAAAA001");
INSERT INTO accesorios value(NULL,"202312290003","PROTAAAA01");
INSERT INTO accesorios value(NULL,"202312290002","MOUSAAAA01");
select * from accesorios;

INSERT INTO proveedor values("PROVAA0001","SOIP690816UBA","Juan","Pedro","Ejemplo","a@a.com",55555555555,1);
/*Select * from proveedor WHERE stat_us = 1 and Id_Prov = "PROVAA0001";*/
Select * from proveedor WHERE stat_us = 1;
insert into productos_a_vender values(NULL,"PROVAA0001","PROTAAAA01");
insert into productos_a_vender values(NULL,"PROVAA0001","AUDAAAA001");
insert into productos_a_vender values(NULL,"PROVAA0001","MOUSAAAA01");

SELECT * from productos_a_vender;



SELECT  pro.id_producto, pro.id_campos_extra, pro.tipo,
    pro.Modelo, pro.Precio, pro.Cantidad, es.id_especificaciones, es.Especificacion, co.id_compatibilidad,
    co.Compatibilidad, com.id_comunicacion, com.Metodo_comunicacion, acc.id_accesorios, acc.Accesorios,
    tec.id_tecnologias, tec.Tecnologia, ex.Color, ex.Material, ex.Tamaño, ex.Capacidad, pro.stat_us 
		FROM productos_a_vender po INNER JOIN productos pro ON po.id_producto = pro.id_producto
        INNER JOIN campos_extra ex ON ex.id_campos_extra = pro.id_campos_extra LEFT JOIN especificaciones es ON es.id_especificaciones = ex.id_especificaciones
        LEFT JOIN compatibilidad co ON co.id_compatibilidad = ex.id_compatibilidad LEFT JOIN metodos_de_comunicacion com ON com.id_comunicacion = ex.id_comunicacion 
        LEFT JOIN accesorios_productos acc ON acc.id_accesorios = ex.id_accesorios LEFT JOIN tecnologias tec ON tec.id_tecnologias = ex.id_tecnologias WHERE Id_Prov = 'PROVAA0001';
        
        
        
        
        
        
        
        SELECT CASE WHEN EXISTS (SELECT 1 FROM Accesorios_productos WHERE id_accesorios = 'ACCPAA0003') THEN 1 ELSE 0 END AS existe_campo;
        
        SELECT Count(id_accesorios) as cuenta FROM Accesorios_productos WHERE id_accesorios = 'ACCPAA0003'; 
        
        /*UPDATE ventas SET stat_us = 1;
        
        DELETE FROM ventas WHERE Id_venta = '202401040401';
        
        SELECT * FROM ventas WHERE stat_us = 1;*/
        
        
        SELECT  pro.id_producto, pro.id_campos_extra, pro.tipo,
    pro.Modelo, pro.Precio, pro.Cantidad, es.id_especificaciones, es.Especificacion, co.id_compatibilidad,
    co.Compatibilidad, com.id_comunicacion, com.Metodo_comunicacion, acc.id_accesorios, acc.Accesorios,
    tec.id_tecnologias, tec.Tecnologia, ex.Color, ex.Material, ex.Tamaño, ex.Capacidad, pro.stat_us 
		FROM accesorios po INNER JOIN productos pro ON po.id_producto = pro.id_producto
        INNER JOIN campos_extra ex ON ex.id_campos_extra = pro.id_campos_extra LEFT JOIN especificaciones es ON es.id_especificaciones = ex.id_especificaciones
        LEFT JOIN compatibilidad co ON co.id_compatibilidad = ex.id_compatibilidad LEFT JOIN metodos_de_comunicacion com ON com.id_comunicacion = ex.id_comunicacion 
        LEFT JOIN accesorios_productos acc ON acc.id_accesorios = ex.id_accesorios LEFT JOIN tecnologias tec ON tec.id_tecnologias = ex.id_tecnologias WHERE Id_venta = '202401040937';
        
        
        /*UPDATE productos SET cantidad = cantidad+5 WHERE id_producto = 'PROTAAAA01';*/
        
        
        
        /*
        ALTER TABLE ventas DROP CHECK ventas_chk_1;
        ALTER TABLE ventas ADD CONSTRAINT ventas_chk_1 CHECK(Id_venta regexp '^(2\d{3})(0?[1-9]|1[1-2]{2})(3[01]|[12][0-9]|(0?[1-9]){1,2})([0-9]{4})$') ;
*/
        
        