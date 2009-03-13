using System.Collections.Generic;

namespace DrDoc
{
    public class DocMethod
    {
        private readonly IList<DocParameter> parameters = new List<DocParameter>();

        public DocMethod(string name)
        {
            Name = name;
        }

        internal void AddParameter(DocParameter parameter)
        {
            parameters.Add(parameter);
        }

        public string Name { get; private set; }
        public IList<DocParameter> Parameters
        {
            get { return parameters; }
        }
    }
}