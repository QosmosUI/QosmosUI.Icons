// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiSpaceShipFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M2.87988 18.049C4.23015 12.0557 7.07526 6.6285 11.003 2.17958C11.1105 2.05778 11.2465 1.90742 11.411 1.72851L11.411 1.72849C11.7101 1.40325 12.2162 1.38203 12.5414 1.68109C12.5579 1.69623 12.5737 1.71205 12.5888 1.72851C12.7553 1.90958 12.8929 2.06164 13.0015 2.1847C16.9268 6.63267 19.7703 12.058 21.12 18.049C18.9786 18.5004 16.7797 18.796 14.5359 18.9235L12.4472 23.101C12.3237 23.348 12.0233 23.4481 11.7763 23.3246C11.6796 23.2762 11.6011 23.1977 11.5527 23.101L9.46401 18.9235C7.22018 18.796 5.02133 18.5004 2.87988 18.049ZM11.9999 14.9954C13.6568 14.9954 14.9999 13.6523 14.9999 11.9954C14.9999 10.3386 13.6568 8.99541 11.9999 8.99541C10.3431 8.99541 8.99994 10.3386 8.99994 11.9954C8.99994 13.6523 10.3431 14.9954 11.9999 14.9954Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
