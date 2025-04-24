// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGooglecardboard : ComponentBase
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
		builder.AddAttribute(15, "d", "M3.087 4.235a3.07 3.07 0 0 0-2.183.91A3.133 3.133 0 0 0 0 7.35v9.296a3.13 3.13 0 0 0 .903 2.206 3.066 3.066 0 0 0 2.184.913h4.28a3.078 3.078 0 0 0 2.713-1.645l1.209-2.276a.785.785 0 0 1 .703-.42.783.783 0 0 1 .701.42l1.21 2.276a3.08 3.08 0 0 0 2.718 1.645h4.292a3.07 3.07 0 0 0 2.184-.913A3.13 3.13 0 0 0 24 16.646V7.35c0-.825-.324-1.618-.904-2.205a3.065 3.065 0 0 0-2.183-.91zm3.495 5.656c1.138 0 2.06.937 2.06 2.092 0 1.157-.922 2.093-2.06 2.093-1.139 0-2.061-.936-2.061-2.093 0-1.155.922-2.092 2.06-2.092zm10.832 0c1.139 0 2.061.937 2.061 2.092 0 1.157-.922 2.093-2.06 2.093-1.14 0-2.063-.936-2.063-2.093 0-1.155.923-2.092 2.062-2.092z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
