// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImVimeo : ComponentBase
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
		builder.AddAttribute(14, "d", "M15.994 4.281c-0.072 1.556-1.159 3.691-3.263 6.397-2.175 2.825-4.016 4.241-5.522 4.241-0.931 0-1.722-0.859-2.366-2.581-0.431-1.578-0.859-3.156-1.291-4.734-0.478-1.722-0.991-2.581-1.541-2.581-0.119 0-0.538 0.253-1.256 0.753l-0.753-0.969c0.791-0.694 1.569-1.388 2.334-2.081 1.053-0.909 1.844-1.387 2.372-1.438 1.244-0.119 2.013 0.731 2.3 2.553 0.309 1.966 0.525 3.188 0.647 3.666 0.359 1.631 0.753 2.447 1.184 2.447 0.334 0 0.838-0.528 1.509-1.588 0.669-1.056 1.028-1.862 1.078-2.416 0.097-0.912-0.262-1.372-1.078-1.372-0.384 0-0.778 0.088-1.184 0.263 0.787-2.575 2.287-3.825 4.506-3.753 1.641 0.044 2.416 1.109 2.322 3.194z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
