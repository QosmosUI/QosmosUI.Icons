// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImVine : ComponentBase
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
		builder.AddAttribute(14, "d", "M15.012 7.953c-0.412 0.094-0.809 0.137-1.169 0.137-2.019 0-3.572-1.409-3.572-3.862 0-1.203 0.466-1.825 1.122-1.825 0.625 0 1.041 0.559 1.041 1.697 0 0.647-0.172 1.356-0.3 1.775 0 0 0.622 1.084 2.322 0.753 0.363-0.803 0.556-1.841 0.556-2.75 0-2.45-1.25-3.878-3.541-3.878-2.356 0-3.734 1.809-3.734 4.197 0 2.366 1.106 4.394 2.928 5.319-0.766 1.534-1.741 2.884-2.759 3.903-1.844-2.231-3.513-5.206-4.197-11.016h-2.722c1.259 9.675 5.006 12.756 6 13.347 0.559 0.337 1.044 0.322 1.556 0.031 0.806-0.456 3.222-2.875 4.563-5.703 0.563 0 1.238-0.066 1.909-0.219v-1.906z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
