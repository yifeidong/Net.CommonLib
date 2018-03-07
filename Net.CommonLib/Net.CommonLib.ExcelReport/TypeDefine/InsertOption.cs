﻿/*******************************************************************
 * * 文件名：
 * * 文件作用：
 * *-------------------------------------------------------------------
 * * 修改历史记录：
 * * 修改时间      修改人    修改内容概要
 * * 2013-02-23    xwj       新增
 * *******************************************************************/

using System;

namespace Net.CommonLib.ExcelReport
{
    [Flags]
    public enum InsertOption
    {
        Never = 0,
        OnFirst = 1,
        OnLast = 2,
        BeforeChange = 4,
        AfterChange = 8,
        Always = 16
    }
}