using MVVM_implementacion_SLE2.VistaModelo;
using MVVM_implementacion_SLE2.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_implementacion_SLE2.VistaModelo
{
    class VMpatron : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONTRUCTOR


        #endregion
        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }


        }


        #endregion
        #region PROCESOS


        public async Task ProcesoAsyncrong()
        {

        }

        public void ProcesoAsync()
        {

        }
        #endregion
    }
}
