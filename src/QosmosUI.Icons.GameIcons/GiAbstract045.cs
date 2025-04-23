// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiAbstract045 : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "m126.6029,21c-58.5338,0-105.6029,47.0641-105.6029,105.6031v258.7938c0,58.539 47.0691,105.6031 105.6029,105.6031h45.3846v-54.3438h37.4529v54.3438h27.4658v-54.3438h38.1875v54.3438h27.4659v-54.3438h37.7467v54.3438h45.0909c58.5338,0 105.6029-47.0641 105.6029-105.6031v-258.7938c0-58.539-47.0691-105.6031-105.6029-105.6031h-45.0909v54.7844h-37.7467v-54.7844h-27.4659v54.7844h-38.1875v-54.7844h-27.4658v54.7844h-37.4529v-54.7844h-45.3846zm129.3972,76.9625c87.2954,0 158.1846,70.7428 158.1846,158.0375s-70.8892,158.1843-158.1846,158.1843-158.1846-70.8897-158.1846-158.1843 70.8891-158.0375 158.1846-158.0375zm0,28.9343c-64.7322,0-118.2901,47.5947-127.6346,109.7157h255.2692c-9.3446-62.121-62.9025-109.7157-127.6346-109.7157zm-127.6346,148.4906c9.3445,62.1433 62.9025,109.8625 127.6346,109.8625s118.29-47.7192 127.6346-109.8625h-255.2692z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
