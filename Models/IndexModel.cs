using System.ComponentModel;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace PimUrbanGreen.Models;

public class IndexModel
    {
        public required string Usuario { get; set; }
        
        public required int Senha { get; set; }

        public required int Produto { get; set; }

        public required int Quantidade { get; set; }
    }