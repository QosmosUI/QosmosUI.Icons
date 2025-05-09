// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiSurroundSoundFill : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M3 3H21C21.5523 3 22 3.44772 22 4V20C22 20.5523 21.5523 21 21 21H3C2.44772 21 2 20.5523 2 20V4C2 3.44772 2.44772 3 3 3ZM7.05025 7.12132C5.7835 8.38807 5 10.1381 5 12.0711C5 14.0041 5.7835 15.7541 7.05025 17.0208L8.46447 15.6066C7.55964 14.7018 7 13.4518 7 12.0711C7 10.6904 7.55964 9.44036 8.46447 8.53553L7.05025 7.12132ZM16.9497 7.12132L15.5355 8.53553C16.4404 9.44036 17 10.6904 17 12.0711C17 13.4518 16.4404 14.7018 15.5355 15.6066L16.9497 17.0208C18.2165 15.7541 19 14.0041 19 12.0711C19 10.1381 18.2165 8.38807 16.9497 7.12132ZM12 15.0711C13.6569 15.0711 15 13.7279 15 12.0711C15 10.4142 13.6569 9.07107 12 9.07107C10.3431 9.07107 9 10.4142 9 12.0711C9 13.7279 10.3431 15.0711 12 15.0711ZM12 13.0711C11.4477 13.0711 11 12.6234 11 12.0711C11 11.5188 11.4477 11.0711 12 11.0711C12.5523 11.0711 13 11.5188 13 12.0711C13 12.6234 12.5523 13.0711 12 13.0711Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
