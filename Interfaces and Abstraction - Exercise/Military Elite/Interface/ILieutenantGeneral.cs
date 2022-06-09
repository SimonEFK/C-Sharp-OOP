using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Interface
{
    public interface ILieutenantGeneral : IPrivate
    {
        public IReadOnlyCollection<IPrivate> PrivateCollection { get; }

        public void AddPrivate(IPrivate @private);
    }
}
