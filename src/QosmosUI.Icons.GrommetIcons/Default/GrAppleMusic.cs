// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrAppleMusic : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "clip-path", "url(#a)");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "fill-rule", "evenodd");
		builder.AddAttribute(17, "d", "M21.992 22.816c.768-.592 1.304-1.424 1.536-2.016.464-1.192.472-2.544.472-3.4V6.6c0-.848 0-2.208-.472-3.4-.232-.592-.776-1.432-1.536-2.016a4.99 4.99 0 0 0-1.688-.88C19.528.08 18.584 0 17.4 0H6.6C5.416 0 4.472.08 3.696.304a5.137 5.137 0 0 0-1.688.88C1.24 1.776.704 2.608.472 3.2.008 4.392 0 5.744 0 6.6v10.8c0 .856.008 2.208.472 3.4.232.592.776 1.432 1.536 2.016.44.344.968.664 1.688.88.776.224 1.72.304 2.904.304h10.8c1.184 0 2.136-.072 2.904-.304a5.137 5.137 0 0 0 1.688-.88Zm-5.706-19.05c.062-.013.576-.104.634-.11.385-.033.6.22.6.63v11.289c0 .303-.003.577-.067.881a2.212 2.212 0 0 1-.348.821 2.087 2.087 0 0 1-.655.606 2.605 2.605 0 0 1-.831.303c-.552.11-.93.136-1.284.065a1.791 1.791 0 0 1-.864-.44 1.88 1.88 0 0 1-.604-1.184 1.886 1.886 0 0 1 .51-1.488c.197-.207.445-.37.776-.499.347-.134.729-.215 1.317-.333l.464-.094c.205-.041.379-.093.52-.265.142-.173.144-.384.144-.593V8.084c0-.404-.182-.514-.566-.44-.276.054-6.19 1.247-6.19 1.247-.333.08-.45.19-.45.603v7.722c0 .303-.015.578-.08.882a2.213 2.213 0 0 1-.348.82 2.088 2.088 0 0 1-.654.606 2.613 2.613 0 0 1-.831.307c-.552.112-.93.136-1.284.065a1.792 1.792 0 0 1-.864-.443 1.863 1.863 0 0 1-.59-1.184 1.874 1.874 0 0 1 .496-1.488c.197-.208.445-.371.776-.5.347-.134.729-.214 1.317-.333l.464-.093c.204-.042.379-.094.52-.266.14-.172.157-.374.157-.582V6.104c0-.12.01-.201.016-.241a.724.724 0 0 1 .24-.462.992.992 0 0 1 .443-.2h.003l7.113-1.435Z");
		builder.AddAttribute(18, "clip-rule", "evenodd");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(19, "defs");
		builder.OpenElement(20, "linearGradient");
		builder.AddAttribute(21, "id", "b");
		builder.AddAttribute(22, "x1", "12");
		builder.AddAttribute(23, "x2", "12");
		builder.AddAttribute(24, "y1", "23.907");
		builder.AddAttribute(25, "y2", ".517");
		builder.AddAttribute(26, "gradientUnits", "userSpaceOnUse");
		builder.OpenElement(27, "stop");
		builder.AddAttribute(28, "stop-color", "#FA233B");
		builder.CloseElement();
		builder.OpenElement(29, "stop");
		builder.AddAttribute(30, "offset", "1");
		builder.AddAttribute(31, "stop-color", "#FB5C74");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(32, "clipPath");
		builder.AddAttribute(33, "id", "a");
		builder.OpenElement(34, "path");
		builder.AddAttribute(35, "d", "M0 0h24v24H0z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
