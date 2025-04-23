// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiContabo : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M11.336 1.816a6.95 6.95 0 0 0-6.879 5.889 7.88 7.88 0 0 1 2.24-.412A4.855 4.855 0 0 1 11.33 3.92a4.853 4.853 0 0 1 3.45 1.44 4.793 4.793 0 0 1 1.197 2.01 7.633 7.633 0 0 1 .875-.067h.33a8.313 8.313 0 0 1 .976.076 6.95 6.95 0 0 0-6.822-5.564zM6.99 8.224A6.983 6.983 0 0 0 0 15.2a6.978 6.978 0 0 0 6.977 6.976 6.966 6.966 0 0 0 4.933-2.03 691.43 691.43 0 0 0 1.56-1.581l-1.488-1.488-1.55 1.582a4.86 4.86 0 0 1-3.452 1.436A4.881 4.881 0 0 1 2.104 15.2a4.877 4.877 0 0 1 4.876-4.871 4.855 4.855 0 0 1 2.819.904l.04-.043 1.466-1.465A6.969 6.969 0 0 0 6.99 8.224zm10.04 0a6.966 6.966 0 0 0-4.936 2.047l-1.59 1.574 1.488 1.489 1.58-1.584A4.88 4.88 0 0 1 21.9 15.2a4.881 4.881 0 0 1-4.877 4.882 4.858 4.858 0 0 1-2.83-.914l-.045.046s-1.078 1.096-1.437 1.467a6.95 6.95 0 0 0 4.312 1.504A6.983 6.983 0 0 0 24 15.205a6.95 6.95 0 0 0-2.04-4.933 6.962 6.962 0 0 0-4.93-2.047z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
