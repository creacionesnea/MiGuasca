using System;
using System.Collections.Generic;
using System.Text;

namespace Accedo_a_BD_MySQL {

    class cProducto {

        private int _pk_id_prod;
        private int _fk_id_cat;
        private String _cod_barra;
        private String _descr;
        private Decimal _precio;
        private Decimal _premay;
        private Decimal _premin;
        private int _stock;
        private int _activo;

        public int Pk_Id_Prod {
            get { return _pk_id_prod; }
            set { _pk_id_prod = value; }
        }
        public int Fk_Id_Cat {
            get { return _fk_id_cat; }
            set { _fk_id_cat = value; }
        }
        public String Cod_Barra {
            get { return _cod_barra; }
            set { _cod_barra = value; }
        }
        public String Desc { 
            get { return _descr; }
            set { _descr = value; }
        }
        public Decimal Precio {
            get { return _precio ; }
            set { _precio = value; }
        }
        public Decimal PrecioMay {
            get { return _premay ; }
            set { _premay = value; }
        }
        public Decimal  PrecioMin {
            get { return _premin ; }
            set { _premin = value; }
        }
        public int Stock {
            get { return _stock; }
            set { _stock = value; }
        }
        public int Activo {
            get { return _activo; }
            set { _activo = value; }
        }

    }

}
