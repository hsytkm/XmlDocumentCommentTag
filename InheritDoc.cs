using System;

namespace XmlDocumentComment
{
    /// <summary>This summary is BaseClass.</summary>
    class BaseClass { }

    /// <summary>This summary is IBase.</summary>
    interface IBase { }

    ///<inheritdoc/>
    class Derived1 : BaseClass { }

    ///<inheritdoc/>
    class Derived2 : BaseClass, IBase { }   // class has priority

    ///<inheritdoc cref="IBase"/>
    class Derived3 : BaseClass, IBase { }   // ref interface
}
