﻿using MovieSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSoftController.DAO
{
    public interface ProductoraDAO
    {
        int insertar(Productora productora);
        int modificar(Productora productora);
        int eliminar(int idProductora);
        BindingList<Productora> listarTodas();
    }
}