using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;
using NpgsqlTypes;
using Npgsql.LegacyPostgis;

namespace netcoreFreesql.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "stor_mtrl", DisableSyncStructure = true)]
	public partial class StorMtrl {

		[JsonProperty, Column(Name = "cpt_id", StringLength = 32, IsPrimary = true)]
		public string CptId { get; set; }

		[JsonProperty, Column(Name = "borrow", StringLength = 10)]
		public string Borrow { get; set; }

		[JsonProperty, Column(Name = "cert_time", StringLength = 12)]
		public string CertTime { get; set; }

		[JsonProperty, Column(Name = "class_id", StringLength = 32)]
		public string ClassId { get; set; }

		[JsonProperty, Column(Name = "cpt_flag", StringLength = 8)]
		public string CptFlag { get; set; }

		[JsonProperty, Column(Name = "cpt_hard")]
		public string CptHard { get; set; }

		[JsonProperty, Column(Name = "cpt_mreq")]
		public string CptMreq { get; set; }

		[JsonProperty, Column(Name = "cpt_name")]
		public string CptName { get; set; }

		[JsonProperty, Column(Name = "cpt_num")]
		public string CptNum { get; set; }

		[JsonProperty, Column(Name = "cpt_price")]
		public double? CptPrice { get; set; }

		[JsonProperty, Column(Name = "cpt_qty", DbType = "numeric")]
		public decimal? CptQty { get; set; }

		[JsonProperty, Column(Name = "cpt_rmk")]
		public string CptRmk { get; set; }

		[JsonProperty, Column(Name = "cpt_spec")]
		public string CptSpec { get; set; }

		[JsonProperty, Column(Name = "cpt_steel")]
		public string CptSteel { get; set; }

		[JsonProperty, Column(Name = "cpt_subqty")]
		public float? CptSubqty { get; set; }

		[JsonProperty, Column(Name = "cpt_subunit")]
		public string CptSubunit { get; set; }

		[JsonProperty, Column(Name = "cpt_sum")]
		public double? CptSum { get; set; }

		[JsonProperty, Column(Name = "cpt_type", StringLength = 2)]
		public string CptType { get; set; }

		[JsonProperty, Column(Name = "cpt_unit")]
		public string CptUnit { get; set; }

		[JsonProperty, Column(Name = "id")]
		public int? Id { get; set; }

		[JsonProperty, Column(Name = "in_attr")]
		public string InAttr { get; set; }

		[JsonProperty, Column(Name = "inventory")]
		public string Inventory { get; set; }

		[JsonProperty, Column(Name = "is_delete", StringLength = 2)]
		public string IsDelete { get; set; }

		[JsonProperty, Column(Name = "mold_id", StringLength = 32)]
		public string MoldId { get; set; }

		[JsonProperty, Column(Name = "moldorother", StringLength = 10)]
		public string Moldorother { get; set; }

		[JsonProperty, Column(Name = "opt_behav")]
		public string OptBehav { get; set; }

		[JsonProperty, Column(Name = "opt_qty", DbType = "numeric")]
		public decimal? OptQty { get; set; }

		[JsonProperty, Column(Name = "opt_time", StringLength = 30)]
		public string OptTime { get; set; }

		[JsonProperty, Column(Name = "opt_type")]
		public string OptType { get; set; }

		[JsonProperty, Column(Name = "optor")]
		public string Optor { get; set; }

		[JsonProperty, Column(Name = "out_attr")]
		public string OutAttr { get; set; }

		[JsonProperty, Column(Name = "out_mach_id", StringLength = 12)]
		public string OutMachId { get; set; }

		[JsonProperty, Column(Name = "out_obj", StringLength = 10)]
		public string OutObj { get; set; }

		[JsonProperty, Column(Name = "out_wrk_id", StringLength = 12)]
		public string OutWrkId { get; set; }

		[JsonProperty, Column(Name = "pcha_id")]
		public string PchaId { get; set; }

		[JsonProperty, Column(Name = "pcha_name")]
		public string PchaName { get; set; }

		[JsonProperty, Column(Name = "pick_id", StringLength = 12)]
		public string PickId { get; set; }

		[JsonProperty, Column(Name = "proc_cost")]
		public double? ProcCost { get; set; }

		[JsonProperty, Column(Name = "ptnr_id", StringLength = 64)]
		public string PtnrId { get; set; }

		[JsonProperty, Column(Name = "real_price")]
		public double? RealPrice { get; set; }

		[JsonProperty, Column(Name = "stor_place")]
		public string StorPlace { get; set; }

		[JsonProperty, Column(Name = "stor_pos")]
		public string StorPos { get; set; }

		[JsonProperty, Column(Name = "sum_price", StringLength = 10)]
		public string SumPrice { get; set; }

		[JsonProperty, Column(Name = "tally_time", StringLength = 30)]
		public string TallyTime { get; set; }

		[JsonProperty, Column(Name = "tax_rate", StringLength = 10)]
		public string TaxRate { get; set; }

		[JsonProperty, Column(Name = "threshold", StringLength = 12)]
		public string Threshold { get; set; }

	}

}
