//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
namespace JetBrains.ReSharper.Psi.FSharp {
  public partial interface IBinaryExpressionNode : JetBrains.ReSharper.Psi.FSharp.Tree.IOperatorExpressionNode,JetBrains.ReSharper.Psi.FSharp.IBinaryExpression {
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode LeftOperandNode { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode RightOperandNode { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetLeftOperandNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param);
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetRightOperandNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param);
  }
}