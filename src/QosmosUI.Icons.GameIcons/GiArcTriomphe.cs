// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiArcTriomphe : ComponentBase
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
		builder.AddAttribute(14, "d", "M64 92v24h24V92H64zm40 0v24h48V92h-48zm64 0v24h48V92h-48zm64 0v24h48V92h-48zm64 0v24h48V92h-48zm64 0v24h48V92h-48zm64 0v24h24V92h-24zM48 132v16h416v-16H48zm16 32v112h128.67c4.696-29.122 34.004-56 63.33-56s58.634 26.878 63.33 56H448V164H64zm17.994 16H184v80H81.373l.56-72.063.061-7.937zM208 180h96v16h-96v-16zm120.063 0h102.005v80H327.441l.559-72.063.063-7.937zM97.869 196l-.371 48H168v-48H97.87zm246.069 0l-.372 48h70.502v-48h-70.13zM64 292v200h128V292H64zm256 0v200h128V292H320zM88 414h80v64H88v-64zm256 0h80v64h-80v-64zm-240 16v32h48v-32h-48zm256 0v32h48v-32h-48z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
