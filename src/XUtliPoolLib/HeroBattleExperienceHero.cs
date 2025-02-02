using System;
using System.Collections.Generic;
using System.IO;

namespace XUtliPoolLib
{
	public class HeroBattleExperienceHero : CVSReader
	{
		public class RowData
		{
			public uint ItemID;

			public uint HeroID;

			public uint LastTime;

			public Seq2ListRef<uint> Reward;

			public string ShowTime;
		}

		public List<HeroBattleExperienceHero.RowData> Table = new List<HeroBattleExperienceHero.RowData>();

		public HeroBattleExperienceHero.RowData GetByItemID(uint key)
		{
			if (this.Table.Count == 0)
			{
				return null;
			}
			int i = 0;
			int count = this.Table.Count;
			while (i < count)
			{
				if (this.Table[i].ItemID == key)
				{
					return this.Table[i];
				}
				i++;
			}
			return null;
		}

		protected override bool OnHeaderLine(string[] Fields)
		{
			string[] colHeaders = new string[]
			{
				"ItemID",
				"HeroID",
				"LastTime",
				"Reward",
				"ShowTime"
			};
			return base.MapColHeader(colHeaders, Fields);
		}

		protected override bool OnLine(string[] Fields)
		{
			HeroBattleExperienceHero.RowData rowData = new HeroBattleExperienceHero.RowData();
			if (!base.Parse(Fields[this.ColMap[0]], ref rowData.ItemID))
			{
				return false;
			}
			if (!base.Parse(Fields[this.ColMap[1]], ref rowData.HeroID))
			{
				return false;
			}
			if (!base.Parse(Fields[this.ColMap[2]], ref rowData.LastTime))
			{
				return false;
			}
			if (!base.Parse<uint>(Fields[this.ColMap[3]], ref rowData.Reward, CVSReader.uintParse, "2U"))
			{
				return false;
			}
			if (!base.Parse(Fields[this.ColMap[4]], ref rowData.ShowTime))
			{
				return false;
			}
			this.Table.Add(rowData);
			return true;
		}

		protected override bool OnCommentLine(string[] Fields)
		{
			return true;
		}

		protected override void WriteLine(string[] Fields, BinaryWriter writer)
		{
			base.Write<uint>(writer, Fields[this.ColMap[0]], CVSReader.uintParse);
			base.Write<uint>(writer, Fields[this.ColMap[1]], CVSReader.uintParse);
			base.Write<uint>(writer, Fields[this.ColMap[2]], CVSReader.uintParse);
			base.WriteSeqList<uint>(writer, Fields[this.ColMap[3]], CVSReader.uintParse, 2, "U");
			base.Write<string>(writer, Fields[this.ColMap[4]], CVSReader.stringParse);
		}

		protected override void ReadLine(BinaryReader reader)
		{
			HeroBattleExperienceHero.RowData rowData = new HeroBattleExperienceHero.RowData();
			base.Read<uint>(reader, ref rowData.ItemID, CVSReader.uintParse);
			this.columnno = 0;
			base.Read<uint>(reader, ref rowData.HeroID, CVSReader.uintParse);
			this.columnno = 1;
			base.Read<uint>(reader, ref rowData.LastTime, CVSReader.uintParse);
			this.columnno = 2;
			base.ReadSeqList<uint>(reader, ref rowData.Reward, CVSReader.uintParse);
			this.columnno = 3;
			base.Read<string>(reader, ref rowData.ShowTime, CVSReader.stringParse);
			this.columnno = 4;
			this.Table.Add(rowData);
			this.columnno = -1;
		}

		protected override void OnClear()
		{
			this.Table.Clear();
		}
	}
}
