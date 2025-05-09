// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiNails : ComponentBase
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
		builder.AddAttribute(14, "d", "M131.656 49.656L22.312 159l12.344 12.344 46.813-28.906 32.686-32.688-.062-.063L144 62l-12.344-12.344zm247.688 0L367 62l26.906 43.563 37.688 37.687 44.75 28.094L488.688 159 379.344 49.656zm4.906 72.688L371.094 135.5l20.687 20.688-32.81-8.594-10.97 11 21.03 21.03-33.342-8.75-10.782 10.814 21.375 21.375-33.874-8.907L87.97 418.626 66.405 472.03l53.313-21.655L416 154.095l-31.75-31.75zm-256.875.625l-31.75 31.75 10.656 10.655 21-21-8.718 33.28 10.813 10.814 21.344-21.345-8.876 33.813 10.625 10.625 21.686-21.688-9.03 34.344 45.56 45.56 31.75-31.75-115.06-115.06zm172.938 172.905l-31.75 31.75 122.75 122.75 53.375 21.563-21.657-53.313-122.717-122.75z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
