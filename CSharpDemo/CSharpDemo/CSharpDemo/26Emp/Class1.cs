using _27DBLib;
namespace _26Emp
{
	[Table(TableName = "Employees")]
	public class Emp
	{

		private int _Eid;
		private string _EName;
		private string _EAddress;

		[Column(ColumnName = "Emp_Address", ColumnType = "varchar(50)")]
		public string EAddress
		{
			get { return _EAddress; }
			set { _EAddress = value; }
		}

        [Column(ColumnName = "Emp_Name", ColumnType = "varchar(50)")]
        public string EName
		{
			get { return _EName; }
			set { _EName = value; }
		}

		[Column(ColumnName ="Emp_Id", ColumnType ="int")]
		public int EID
		{
			get { return _Eid; }
			set { _Eid = value; }
		}


	}
}
