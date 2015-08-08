using System;
using System.Data;
using System.Collections.Generic;
using Mycms.Model;
namespace Mycms.BLL
{
	/// <summary>
	/// ϵͳƵ��
	/// </summary>
	public partial class sys_channel
	{
        private readonly Mycms.DAL.sys_channel dal = new Mycms.DAL.sys_channel();
		public sys_channel()
		{}
		#region  Method
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

        /// <summary>
        /// ��������Ƿ����
        /// </summary>
        public bool Exists(string name)
        {
            return dal.Exists(name);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(Mycms.Model.sys_channel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Mycms.Model.sys_channel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int id)
		{
			return dal.Delete(id);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Mycms.Model.sys_channel GetModel(int id)
		{
			return dal.GetModel(id);
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

		#endregion  Method
	}
}

