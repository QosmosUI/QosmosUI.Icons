// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMedal : ComponentBase
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
		builder.AddAttribute(14, "d", "M140.5 19.156V192.28l21.813 28.532h15.53V19.156H140.5zm56.03 0v201.656h122.064V19.156H196.53zm140.75 0v201.656h12.345l22.094-28.53V19.155h-34.44zM173.94 239.5v18.125H338.03V239.5H173.94zm30.78 36.813l8.032 10.53c-25.262 12.014-45.128 33.46-55.094 59.813l65.03 47.47 5.47 3.968-2.094 6.437-17.312 53.69 45.656-33.064 5.5-3.97 5.47 3.97 62.468 45.22c24.872-19.957 40.78-50.6 40.78-85.063 0-6.494-.573-12.854-1.655-19.032l-58.845 42.94-11-15.095L361.688 347c-10.683-28.55-32.932-51.392-61.125-62.78l6.125-7.908h-38.813l-25.5 78-17.75-5.812 23.594-72.188h-43.5zm-52.374 89.625c-1.123 6.286-1.72 12.76-1.72 19.375 0 32.163 13.84 61.008 35.907 80.937l19.69-61.03-53.876-39.283zm107.562 78.343l-51.53 37.314c15.266 8.124 32.707 12.72 51.25 12.72 18.673-.002 36.218-4.676 51.562-12.908l-51.282-37.125z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
