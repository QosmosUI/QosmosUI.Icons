// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiCloudMoon : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Cloud_Moon");
		builder.AddAttribute(15, "data-name", "Cloud Moon");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M21.36,11.54a.71.71,0,0,0-.73-.29,5.278,5.278,0,0,1-6.34-4.78,5.379,5.379,0,0,1,.37-2.42.729.729,0,0,0-.15-.78.7.7,0,0,0-.76-.16A6.317,6.317,0,0,0,9.77,8.99a5.494,5.494,0,0,0-1.22-.13A6.039,6.039,0,0,0,2.5,14.89c0,.1.01.2.01.3A6.114,6.114,0,0,0,8.7,20.94h5.99a3.941,3.941,0,0,0,3.98-3.61,3.755,3.755,0,0,0-.63-2.38A6.283,6.283,0,0,0,21.4,12.3.682.682,0,0,0,21.36,11.54Zm-6.67,8.4H8.7a5.121,5.121,0,0,1-5.19-4.8A5.042,5.042,0,0,1,8.55,9.86a5.059,5.059,0,0,1,4.92,3.95.548.548,0,0,0,.26.37l.25.13.2-.05a2.873,2.873,0,0,1,3.49,3A2.931,2.931,0,0,1,14.69,19.94Zm2.61-5.83a3.917,3.917,0,0,0-2.95-.89A6.043,6.043,0,0,0,10.78,9.3a5.338,5.338,0,0,1,2.73-4.98,6.325,6.325,0,0,0,4.51,7.85,6.642,6.642,0,0,0,2.12.17A5.2,5.2,0,0,1,17.3,14.11Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
