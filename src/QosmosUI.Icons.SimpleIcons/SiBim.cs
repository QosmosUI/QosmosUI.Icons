// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiBim : ComponentBase
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
		builder.AddAttribute(15, "d", "M3.327 6.3015c-1.8378 0-3.3266 1.4908-3.3266 3.3283v4.7424c0 1.8375 1.4888 3.3263 3.3265 3.3263h17.347c1.8376 0 3.3265-1.4888 3.3265-3.3263V9.6298c0-1.8375-1.4889-3.3283-3.3265-3.3283H12.353L11.06 8.1922 9.7863 6.3015Zm1.5742 2.1896c.8137-.0085 1.57.0699 2.01.2422.7978.3017 1.254.96 1.293 1.8067.0294.612-.2962 1.1623-.791 1.5801.5608.3311.9783.8269.9649 1.5392-.0257 1.2596-1.2067 2.0391-3.3362 1.9903-1.1473-.0269-1.7047-.0285-2.3694-.1739V8.6395c1.1595-.1564 1.288-.14 2.2287-.1484Zm9.5223.1113h1.9903l1.2833 3.2247 1.2735-3.2247h2.0511l.5507 6.8675h-1.9707l-.1446-3.9123-1.7716 3.8986-1.6466-3.885-.3418 3.8987h-2.0158Zm-4.4732.0234h2.0901v6.8675h-2.09Zm-5.2347 1.4298v1.4532h.8086a.7257.7257 0 0 0 .7266-.7266c0-.4008-.2965-.7266-.7266-.7266zm0 2.7872v1.1973h.7793c.4105.0232.9576-.1498.963-.586-.0245-.4923-.5244-.637-.9337-.6113z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
