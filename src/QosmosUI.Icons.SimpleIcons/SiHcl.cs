// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiHcl : ComponentBase
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
		builder.AddAttribute(15, "d", "M21.3968 10.4013l-1.0971 2.4399H24l-.3435.7629H17.294l1.4331-3.2028zm-6.3985 1.0896h2.4633c-.0152-.5377-.5358-.911-1.5672-1.0592-2.0348-.2994-4.2354-.1718-5.802.6934-1.2346.6859-1.329 1.7176-.099 2.2232 1.0357.4218 3.2106.4656 4.767.201 1.0077-.1712 1.7776-.502 2.2093-.9974H14.454c-.3262.251-.7526.376-1.25.3804-1.4124.0094-1.5988-.4182-1.3525-.9106.293-.5801.9075-.8966 1.8447-.9216.7381-.0199 1.1029.1436 1.3021.3908M0 13.6067h2.604l.5578-1.2789h2.553l-.5732 1.2771h2.635l1.4457-3.2031h-2.653l-.4769 1.0807H3.5421l.4831-1.0807-2.5781-.0006Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
