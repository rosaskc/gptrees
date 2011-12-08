﻿// -----------------------------------------------------------------------
// <copyright file="BTreeFactory.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System;
using ForRest.Provider.BLL;

namespace ForRest.BTree
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class BTreeFactory : ITreeFactory
    {
        public string GetPluginName()
        {
            return "B-Tree Plugin";
        }

        public string GetPluginDescription()
        {
            return "Plugin that implements B-Tree Algorithms";
        }

        public ITree<T> GetTree<T>()
        {
            object obj = Activator.CreateInstance(typeof(BTree<>).MakeGenericType(typeof(T)));
            var t = (ITree<T>)obj;
            return t;
        }
    }
}