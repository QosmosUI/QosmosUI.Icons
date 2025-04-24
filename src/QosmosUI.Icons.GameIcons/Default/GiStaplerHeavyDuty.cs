// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiStaplerHeavyDuty : ComponentBase
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
		builder.AddAttribute(14, "d", "M397.3 79.45v22.25h83.8V79.45zm-294.7.19c-26.04.09-50.75 10.72-50.75 10.72C92.56 149.9 159.2 101.9 280.2 231.4l33.1-5.9 36.5-34.1S189.6 113.7 132.3 85.66c-9.2-4.46-19.6-6.05-29.7-6.02zm321.1 31.96v11.1h31.2v-11.1zm-26.8 23.2 22.3 88.1 61.5 25.1V134.8zm-2.3 43.7L323.7 248s-156.8 26.2-237.02 39.7c-26.63 4.5-46.14 27.5-46.14 54.5v43.1l45.54 31.3v32H388.5l-1.4-40.6 41.9-5.3-4.1-163.1-16.6-6.9zm48.4 68.4 4.2 171.8-41.8 5.4.8 24.5h74.9V262.4zM102.9 320h228.3c14.7 0 26.6 12 26.6 26.7s-11.9 26.7-26.6 26.7H102.9c-14.71 0-26.66-12-26.66-26.7S88.19 320 102.9 320zm-71.95 74.8v53.6h41.8v-24.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
