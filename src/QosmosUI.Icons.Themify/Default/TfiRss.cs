// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiRss : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M9.969 14h-1c0-3.233-2.678-5.863-5.969-5.863v-1c3.843 0 6.969 3.079 6.969 6.863zM3 3.5v1c5.327 0 9.5 4.173 9.5 9.5h1c0-5.888-4.612-10.5-10.5-10.5zM6 12.501c0-0.827-0.671-1.501-1.497-1.501-0.829 0-1.503 0.674-1.503 1.501s0.674 1.5 1.503 1.5c0.826 0 1.497-0.673 1.497-1.5zM5 12.501c0 0.275-0.223 0.5-0.497 0.5-0.277 0-0.503-0.225-0.503-0.5 0-0.276 0.226-0.501 0.503-0.501 0.274 0 0.497 0.225 0.497 0.501zM17 15.5v-14c0-0.827-0.673-1.5-1.5-1.5h-14c-0.827 0-1.5 0.673-1.5 1.5v14c0 0.827 0.673 1.5 1.5 1.5h14c0.827 0 1.5-0.673 1.5-1.5zM15.5 1c0.276 0 0.5 0.225 0.5 0.5v14c0 0.275-0.224 0.5-0.5 0.5h-14c-0.276 0-0.5-0.225-0.5-0.5v-14c0-0.275 0.224-0.5 0.5-0.5h14z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
