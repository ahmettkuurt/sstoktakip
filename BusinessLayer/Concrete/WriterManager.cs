﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal _writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

        public void AddT(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void DeleteT(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWritersById(int id)
        {
            return _writerDal.GetListAll(x=>x.WriterID == id);
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public void UpdateT(Writer t)
        {
            _writerDal.Update(t);
        }

        public void WriterAdd(Writer writer)
		{
			_writerDal.Insert(writer);
		}
	}
}
