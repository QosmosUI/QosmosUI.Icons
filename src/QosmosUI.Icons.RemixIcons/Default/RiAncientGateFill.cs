// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiAncientGateFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M6.9641 3H17.0359C17.2844 4.722 18.7602 6 20.5 6C20.8322 6 21.1626 5.95271 21.4815 5.85956C21.2972 7.64386 19.7938 9 18 9H6C4.20622 9 2.7028 7.64386 2.51852 5.85957C2.83736 5.95271 3.16783 6 3.5 6C5.23985 6 6.71555 4.722 6.9641 3ZM22.9786 11.1114C22.5422 11.3591 22.0376 11.5005 21.5 11.5005C20.3896 11.5005 19.4201 10.8972 18.9013 10.0005H5.09865C4.57994 10.8972 3.61042 11.5005 2.5 11.5005C1.96237 11.5005 1.45778 11.3591 1.02138 11.1114C1.00725 11.2391 1 11.369 1 11.5005C1 12.8967 1.81753 14.1019 3 14.6637V21H9V19C9 17.3431 10.3432 16 12 16C13.6569 16 15 17.3431 15 19V21H21V14.6637C22.1825 14.1019 23 12.8967 23 11.5005C23 11.369 22.9927 11.2391 22.9786 11.1114Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
