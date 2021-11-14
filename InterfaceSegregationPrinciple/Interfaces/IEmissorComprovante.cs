﻿using InterfaceSegregationPrinciple.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Interfaces
{
    public interface IEmissorComprovante
    {
        public Comprovante emitir(PagamentoRequest pagamentoRequest);
    }
}
