// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBlast : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 16c-72 0-120 48.094-120 96.093 0 48.416 24.277 66.635 51.563 112.5-3.476 47.475-3.75 111.834-3.75 199.218 15.588-51.96 28.137-91.943 38.437-121.406C236.71 347.18 249.23 407.97 256 495.997c6.77-88.027 19.288-148.818 33.75-193.593 10.3 29.462 22.85 69.444 38.438 121.407 0-87.915-.21-152.607-3.75-200.156C351.563 178.276 376 160.274 376 112.09 376 64.09 328 16 256 16zm0 47.813c39.765 0 72.188 26.863 72.188 60 0 13.097-5.516 25.29-14.063 35.156-10.095-33.71-27.39-46.876-58.125-46.876s-48.03 13.167-58.125 46.875c-8.547-9.866-14.063-22.06-14.063-35.158 0-33.136 32.423-60 72.188-60z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
