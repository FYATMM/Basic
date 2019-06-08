﻿using System;
/// <summary>
/// Remove Parameters 是一项重构操作，提供了一种将形参从方法、索引器或委托中移除的简单方法。 “移除参数”会更改声明；并在调用该成员的所有位置移除形参，从而反映新的声明。
/// 
/// 要执行“删除参数”操作，请首先将光标放在方法、索引器或委托上。 当光标位于适当的位置时，若要调用 Remove Parameters 操作，请单击“重构”菜单，按键盘快捷方式，或从快捷菜单中选择相应命令。
/// 
/// 您无法移除扩展方法中的第一个参数。
/// 
/// 可以从方法声明或方法调用中移除参数。 请将光标置于方法声明或委托名称中，然后调用“移除参数”。
/// 
/// 使用“移除参数”，您可以移除在成员体中引用的参数，但这不会移除在方法体中对该参数的引用。 这可能会在您的代码中引入生成错误。
/// 但是，您可以使用“预览更改”对话框在执行重构操作之前检查代码。
/// 
/// 如果正在移除的参数在调用方法的过程中被修改，则移除参数的同时也将移除所做的修改。 例如，如果重构操作将某个方法调用由param1++, param1 将不会递增。
/// </summary>
namespace RefactoryingRemoveParameterDemo
{
    public class RemoveParameterDemo
    {
    }
}