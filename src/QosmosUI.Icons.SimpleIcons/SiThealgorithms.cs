// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiThealgorithms : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M8.226,19.857H1.353l1.79-4.225h4.812L13.308,3.21H7.564l-4.226,9.82h2.587c.18.3.511.51.887.51a1.04,1.04,0,0,0,1.038-1.037c0-.572-.467-1.023-1.038-1.023-.421,0-.767.24-.932.602H4.647l3.503-7.94h3.76L7.383,14.684l-4.766.03L0,20.79h8.842L10,18.263h3.835l1.278,2.526H24L15.985,3.211Zm2.27-2.586,1.384-3.023,1.503,3.023zm5.218,2.691-.872-1.759h2.737c.18.33.526.556.917.556a1.04,1.04,0,0,0,1.038-1.037,1.04,1.04,0,0,0-1.038-1.038c-.42,0-.782.256-.947.617H14.42l-2.09-4.06,1.534-3.369,1.729,3.519h.812c.165.346.526.601.932.601a1.04,1.04,0,0,0,1.038-1.037,1.04,1.04,0,0,0-1.038-1.038c-.436,0-.812.271-.962.662h-.3l-1.79-3.64,1.699-3.728,6.677,14.751Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
