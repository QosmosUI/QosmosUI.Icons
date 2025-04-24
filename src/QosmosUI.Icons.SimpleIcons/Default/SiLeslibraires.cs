// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiLeslibraires : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.79.002a10.579 10.579 0 0 0-7.735 3.575C.18 7.958.593 14.647 4.981 18.518a10.557 10.557 0 0 0 5.3 2.51L12.002 24l1.717-2.971a10.56 10.56 0 0 0 6.227-3.437c3.876-4.38 3.461-11.07-.926-14.94a10.567 10.567 0 0 0-7.23-2.65zM11.277 7.5l.613.512-1.862 2.444c-.005.007-.048.06-.048.115 0 .056.045.112.045.113l1.866 2.461-.615.502-2.573-2.403a.883.883 0 0 1-.3-.667c0-.38.22-.596.304-.678zm3.265 0 .613.512-1.863 2.444c-.005.007-.048.06-.048.115 0 .056.045.112.046.113l1.866 2.461-.615.502-2.573-2.403a.883.883 0 0 1-.301-.667c0-.38.222-.596.305-.678z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
