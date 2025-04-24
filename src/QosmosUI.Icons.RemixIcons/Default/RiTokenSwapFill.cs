// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiTokenSwapFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M21.5 9C21.5 11.7039 19.849 14.0223 17.5 15.0018L17.5 15C17.5 10.3056 13.6944 6.5 9.00001 6.5L8.99817 6.5C9.97773 4.15105 12.2961 2.5 15 2.5C18.5899 2.5 21.5 5.41015 21.5 9ZM7 3C4.79086 3 3 4.79086 3 7V8.5H5V7C5 5.89543 5.89543 5 7 5H8.5V3H7ZM19 15.5V17C19 18.1046 18.1046 19 17 19H15.5V21H17C19.2091 21 21 19.2091 21 17V15.5H19ZM9 21.5C12.5899 21.5 15.5 18.5899 15.5 15C15.5 11.4101 12.5899 8.5 9 8.5C5.41015 8.5 2.5 11.4101 2.5 15C2.5 18.5899 5.41015 21.5 9 21.5ZM9 12.5L11.5 15L9 17.5L6.5 15L9 12.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
