// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImSortAlphaAsc : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M5 12v-12h-2v12h-2.5l3.5 3.5 3.5-3.5h-2.5z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M14.5 16h-4c-0.184 0-0.354-0.101-0.441-0.264s-0.077-0.36 0.025-0.513l3.482-5.223h-3.066c-0.276 0-0.5-0.224-0.5-0.5s0.224-0.5 0.5-0.5h4c0.184 0 0.354 0.101 0.441 0.264s0.077 0.36-0.025 0.513l-3.482 5.223h3.066c0.276 0 0.5 0.224 0.5 0.5s-0.224 0.5-0.5 0.5z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M15.947 6.276l-3-6c-0.085-0.169-0.258-0.276-0.447-0.276s-0.363 0.107-0.447 0.276l-3 6c-0.123 0.247-0.023 0.547 0.224 0.671 0.072 0.036 0.148 0.053 0.223 0.053 0.183 0 0.36-0.101 0.448-0.277l0.862-1.724h3.382l0.862 1.724c0.123 0.247 0.424 0.347 0.671 0.224s0.347-0.424 0.224-0.671zM11.309 4l1.191-2.382 1.191 2.382h-2.382z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
