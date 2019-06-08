﻿using System;
/// <summary>
/// “提取接口”是一项重构操作，提供了一种使用来自现有类、结构或接口的成员创建新接口的简单方法。
/// 
/// 当几个客户端使用类、结构或接口中成员的同一子集时，或者当多个类、结构或接口具有通用的成员子集时，在接口中嵌入成员子集将很有用。
/// 
/// “提取接口”在新文件中生成接口，并将光标定位于新文件的开头。 使用“提取接口”对话框，可以指定要提取到新接口中的成员、新接口的名称以及所生成的文件的名称。
/// 
/// 仅当将光标定位于包含要提取成员的类、结构或接口中时，才可以访问此功能。 当光标处于此位置时，调用“提取接口”重构操作。
/// 
/// 在类或结构中调用“提取接口”时，将修改基和接口列表，以包括新接口名称。 而在接口中调用“提取接口”时，将不修改基和接口列表。
/// </summary>
namespace RefactoringExtractionInterface
{
    public class ExtractionInterfaceDemo
    {
    }
}