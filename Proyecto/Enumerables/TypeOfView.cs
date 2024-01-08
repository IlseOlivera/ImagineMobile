using System.ComponentModel;

namespace Proyecto_BD.Enumerables
{
    //El tipo de vista que se maneja
    public enum TypeOfView
    {
        //Vista para registrar empleado
        Regist_new_employee = 0,
        //Actualizar empleado
        Update_employee = 1,
        //Ver los empleado
        See_empleoyees = 2,
        //Ver los productos
        See_products = 3,
        //Ver los proveedores
        See_supplier = 4,
        //registrar proveedor
        Regist_new_supplier = 5,
        //Actualizar proveedor
        Update_supplier = 6,
        //Crear nuevo producto
        Create_new_product = 7,
        //Actualizar prodicto
        Update_product = 8,
        //Agregar producto del proveedor
        Add_product_for_supplier = 9,
    }
}
