﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kaufer_comex.Models
{
    public class NovaNotaView
    {

		[Display(Name = "Número Nf (*)")]
		public int NumeroNf { get; set; }

		[Display(Name = "Emissão (*)")]
		public DateTime Emissao { get; set; }

		[Display(Name = "Base Nota (*)")]
		public DateTime BaseNota { get; set; }

		[Display(Name = "Valor Fob (*)")]
		public float ValorFob { get; set; }

		[Display(Name = "Valor Frete (*)")]
		public float ValorFrete { get; set; }

		[Display(Name = "Valor Seguro (*)")]
		public float ValorSeguro { get; set; }

		[Display(Name = "Valor Cif (*)")]
		public float ValorCif { get; set; }

		[Display(Name = "Peso Liq (*)")]
		public float PesoLiq { get; set; }

		[Display(Name = "Peso Bruto (*)")]
		public float PesoBruto { get; set; }

		[Display(Name = "Taxa Cambial (*)")]
		public float TaxaCambial { get; set; }

		[Display(Name = "Certificado Qualidade (*)")]
		public string CertificadoQualidade { get; set; }


		[Display(Name = "Embarque Rodoviário (*)")]
		public int EmbarqueRodoviarioId { get; set; }

		[ForeignKey("EmbarqueRodoviarioId")]
		public EmbarqueRodoviario EmbarqueRodoviario { get; set; }

		[Display(Name = "Veículo (*)")]
		public int VeiculoId { get; set; }

		public Veiculo Veiculo { get; set; }

		[Required(ErrorMessage = "O campo é obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/YYYY}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        public Nota Nota { get; set; }

        public NotaItem NotaItem { get; set; }

        public NotaItemTemp NotaItemTemp { get; set; }

		public AdicionaItemView AdicionaItem { get; set; }

		
        public double QuantidadeTotal { get { return NotaItemTemps == null ? 0 : NotaItemTemps.Sum(d => d.Quantidade); } }

		[Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ValorTotal { get { return NotaItemTemps == null ? 0 : NotaItemTemps.Sum(d => d.Valor); } }

		public List<NotaItem> NotaItens { get; set; }

        public List<NotaItemTemp> NotaItemTemps { get; set; }

        public List<Nota> Notas { get; set; }

		public List<AdicionaItemView> Itens { get; set; }

	}
}
