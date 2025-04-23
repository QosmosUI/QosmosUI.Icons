// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCapricorn : ComponentBase
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
		builder.AddAttribute(14, "d", "M222.733 125.562c-16.18-2.68-22.596 79.184-24.955 118.284l-67.715.1c-2.892-103.625-4.257-113.83-19.966-141.418-7.18-12.618-28.344-14.49-28.344-14.49 0-13.44-.135-68.432-.135-68.432 37.287 0 63.14 26.92 79.424 56.544l2.427-5.455c7.912-16.947 26.824-49.99 64.08-49.99 117.498 0 42.747 323.118 145.476 296.482 6.634-1.72 17.087-23.246-3.94-23.246-37.993 5.053-52.152 210.634-175.335 193.995-11.794-1.59-18.916-4.83-18.916-4.83l8.505-73.157c22.63 2.82 54.084-15.122 58.147-26.623 17.15-48.603 44.853-168.058 133.866-168.058 34.016 0 72.754 32.918 72.754 90.73 0 94.424-169.585 154.09-208.16-49.384-8.235-43.37-4.317-134.282-17.214-131.05z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
