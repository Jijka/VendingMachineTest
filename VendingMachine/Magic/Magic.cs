﻿using System;

namespace VendingMachine.Magic
{
    /// <summary>
    /// Используется вместо реализации INotifyPropertyChanged
    /// </summary>
    internal class MagicAttribute : Attribute { }

    /// <summary>
    /// Используется вместо реализации INotifyPropertyChanged
    /// </summary>
    internal class NoMagicAttribute : Attribute { }

}