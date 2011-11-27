﻿// -----------------------------------------------------------------------
// <copyright file="BinarySearchTreeNode.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using ForRest.Provider.BLL;

namespace ForRest.BST
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class BinarySearchTreeNode<T> : Node<T>
    {   
        public BinarySearchTreeNode()
        {
        }

        public BinarySearchTreeNode(T data) : base(data, null)
        {
        }

        public BinarySearchTreeNode(T data, BinarySearchTreeNode<T> left, BinarySearchTreeNode<T> right)
        {
            Value = data;
            NodeList<T> children = new NodeList<T>(2);
            children[0] = left;
            children[1] = right;
            Neighbors = children;
        }

        public BinarySearchTreeNode<T> Left
        {
            get
            {
                if (Neighbors == null)
                    return null;
                else
                    return (BinarySearchTreeNode<T>) Neighbors[0];
            }
            set
            {
                if (Neighbors == null)
                    Neighbors = new NodeList<T>(2);
                Neighbors[0] = value;
            }
        }
        public BinarySearchTreeNode<T> Right
        {
            get
            {
                if (Neighbors == null)
                    return null;
                else
                    return (BinarySearchTreeNode<T>) Neighbors[1];
            }
            set
            {
                if (Neighbors == null)
                    Neighbors = new NodeList<T>(2);
                Neighbors[1] = value;
            }
        }
    }
}