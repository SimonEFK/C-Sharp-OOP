using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Interface;

namespace Military_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<IPrivate> privateCollection;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {


            privateCollection = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> PrivateCollection => privateCollection.AsReadOnly();

        public void AddPrivate(IPrivate @private)
        {
            privateCollection.Add(@private);
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (var item in PrivateCollection)
            {
                sb.AppendLine($"  {item.ToString()}");
            }
            return sb.ToString().Trim();
        }
    }
}
