using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.Data.Dao;

namespace G.Data.Context
{
    public class RepositoryFlywieghtFactory
    {
        Dictionary<string, IStrategy> sharedRepository =
            new Dictionary<string, IStrategy>();

        public IStrategy this[string repository]
        {
            get
            {
                if (!sharedRepository.ContainsKey(repository))
                {
                    switch (repository)
                    {
                        case "Bovino":
                            return sharedRepository[repository] = new BovinoRepository();
                        default:
                            return null;
                    }
                }
                else
                {
                    return sharedRepository[repository];
                }
            }
        }
    }
}