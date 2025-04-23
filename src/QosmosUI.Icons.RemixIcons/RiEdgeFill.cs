// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiEdgeFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M20.645 8.586C20.475 7.875 20.204 7.138 19.871 6.565C19.1 5.236 18.407 4.328 16.694 3.245C14.981 2.162 13.077 2 12.171 2C9.75598 2 7.95998 2.86 6.64598 3.887C3.34498 6.47 3.00098 11 3.00098 11C3.00098 11 4.22198 8.955 6.54098 7.474C7.94398 6.579 9.94198 6 11.569 6C15.886 6 16.001 10 16.001 10H9.00098C9.00098 8 10.001 7 10.001 7C10.001 7 5.00098 9 5.00098 14.044C5.00098 14.531 4.99798 15.416 5.24898 16.327C5.48098 17.17 5.94898 18.032 6.38098 18.68C7.60198 20.512 9.42598 21.294 10.297 21.584C11.293 21.916 12.326 22 13.307 22C16.027 22 18.184 21.114 19.001 20.725V16.553C18.243 17.007 16.322 18 14.001 18C9.00098 18 9.00098 14 9.00098 14H21.001V11.51C21.001 11.51 20.962 9.917 20.645 8.586Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
