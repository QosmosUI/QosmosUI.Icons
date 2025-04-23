// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiSignpostDuo1 : ComponentBase
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
		builder.AddAttribute(14, "id", "Signpost_Duo_1");
		builder.AddAttribute(15, "data-name", "Signpost Duo 1");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M20.437,11.5H6.536a2.628,2.628,0,0,1-1.723-.629L2.564,8.915A1.329,1.329,0,0,1,2.57,6.831L4.813,4.88a2.619,2.619,0,0,1,1.723-.629h13.9a1.451,1.451,0,0,1,1.5,1.393v4.463A1.451,1.451,0,0,1,20.437,11.5Zm-13.9-6.25a1.64,1.64,0,0,0-1.067.384L3.215,7.6a.364.364,0,0,0-.152.281.349.349,0,0,0,.141.27l.011.01,2.254,1.961a1.644,1.644,0,0,0,1.067.384h13.9a.463.463,0,0,0,.5-.394V5.644a.463.463,0,0,0-.5-.393Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M17.464,19.749H3.563a1.451,1.451,0,0,1-1.5-1.394V13.892a1.451,1.451,0,0,1,1.5-1.393h13.9a2.621,2.621,0,0,1,1.724.63l2.249,1.956a1.329,1.329,0,0,1-.007,2.083l-2.242,1.951A2.625,2.625,0,0,1,17.464,19.749ZM3.563,13.5a.463.463,0,0,0-.5.393v4.463a.463.463,0,0,0,.5.394h13.9a1.644,1.644,0,0,0,1.068-.385l2.253-1.96a.362.362,0,0,0,.152-.28.351.351,0,0,0-.141-.271l-.011-.01-2.254-1.96a1.64,1.64,0,0,0-1.067-.384Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
