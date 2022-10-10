﻿using LanchesMac.Models;
using LanchesMac.ViewsModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Components;

public class CarrinhoCompraResumo : ViewComponent
{
    private readonly CarrinhoCompra _carrinhoCompra;

    public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
    {
        _carrinhoCompra = carrinhoCompra;
    }

    public IViewComponentResult Invoke()
    {
        _carrinhoCompra.CarrinhoCompraItens = _carrinhoCompra.GetCarrinhoCompraItens();

        var carrinhoCompraVM = new CarrinhoCompraViewModel
        { CarrinhoCompra = _carrinhoCompra, CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal() };
        return View(carrinhoCompraVM);
    }
}