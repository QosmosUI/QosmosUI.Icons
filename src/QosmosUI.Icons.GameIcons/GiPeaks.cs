// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPeaks : ComponentBase
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
		builder.AddAttribute(14, "d", "M245.795 19.12l-52.363 153.513 26.67 61.937 38.884-52.37 53.217 67.493 11.682-40.486-78.09-190.086zM101.172 193.69l-29.06 80.222 24.54-12.715 24.803 14.33 11.64-48.013-31.923-33.825zm83.267 5.308l-20.776 60.904-15.27-16.177-14.662 60.48-37.568-21.707-33.44 17.324L19.04 420.42l84.884 30.937 73.418-22.437 73.935 19.47 71.66-21.536 91.973 25.226 77.28-31.66-48.44-89.006-39.045 26.664-38.892-27.576-27.153 42.79-15.78-10.013 39.032-61.51-26.6-64.752-15.246 52.83-60.634-76.9-43.664 58.81-31.33-72.76zm223.06 65.81L375.84 314.7l29.066 20.61 29.865-20.394-27.27-50.11z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
