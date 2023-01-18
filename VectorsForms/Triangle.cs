using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VectorsForms
{
    internal class Triangle:DomainObject
    {
        private int _v1_id, _v2_id;
        private Vector? _v1, _v2;

        public int v1_id
        {
            get { return _v1_id; }

            set { //если id меняем, то v1 уже не прогружен
                _v1_id = value;
                _v1 = null; 
            }
        }

        public int v2_id
        {
            get { return _v2_id; }

            set
            { //если id меняем, то v1 уже не прогружен
                _v2_id = value;
                _v2 = null;
            }
        }

        public Vector? v1
        {
            set
            {
                _v1=value;
            }
            get
            {
                //если объект не прогружен
                if (_v1 == null)
                {
                    //пытаемся его прогрузить
                    if (v1_id > 0)
                    {
                        Mapper mapper = new Mapper("vectors");
                        _v1 = (Vector)mapper.GetById(v1_id);
                        Console.WriteLine($"Лениво загружаем Вектор {v1_id}");
                    }
                    else
                    {
                        if (v1_id != 0)
                        {
                            //id неверный
                            throw new Exception("Не могу загрузить объект");
                        }
                        else
                        {
                            //объект не из базы, создан в программе
                            _v1 = null;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Уже лениво загружен Вектор {v1_id}");
                }
                return _v1;
            }
        }

        public Vector? v2
        {
            set
            {
                _v2 = value;
            }
            get
            {
                //если объект не прогружен
                if (_v2 == null)
                {
                    //пытаемся его прогрузить

                    if (_v2_id > 0)
                    {
                        Mapper mapper = new Mapper("vectors");
                        _v2 = (Vector)mapper.GetById(_v2_id);
                        Console.WriteLine($"Лениво загружаем Вектор {_v2_id}");
                    }
                    else
                    {
                        if (_v2_id != 0)
                        {
                            //id неверный
                            throw new Exception("Не могу загрузить объект");
                        }
                        else
                        {
                            //объект не из базы, создан в программе
                            _v2 = null;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Уже лениво загружен Вектор {v2_id}");
                }
                return _v2;
            }
        }

        public Triangle(List<string> _params) : base(_params) { }

        protected override void LoadObject(List<string> _params)
        {
            Mapper mapper = new Mapper("vectors");
            _v1_id = Convert.ToInt32(_params[1]);
            _v2_id = Convert.ToInt32(_params[2]);
        }
        public override string InsertObjectString()
        {
            return $"triangles(v1_id,v2_id) VALUES ({v1._id},{v2._id}";
        }
        public override string SetObjectString()
        {
            return $"v1_id='{v1._id}' , v2_id='{v2._id}' WHERE  id={_id}";
        }        
    }
}
