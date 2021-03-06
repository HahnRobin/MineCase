﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MineCase.Game.Windows;
using MineCase.Server.Game.BlockEntities;

namespace MineCase.Server.Game.Windows
{
    public interface IFurnaceWindow : IWindow
    {
        Task SetEntity(IBlockEntity furnaceEntity);

        Task SetProperty(FurnaceWindowPropertyType property, short value);
    }
}
