// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscCircleSmall : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M8.83185 8.55551C8.72192 8.72004 8.56569 8.84825 8.38305 8.9239C8.20039 8.99956 7.99936 9.01936 7.80531 8.98076C7.61133 8.94218 7.43313 8.84693 7.29328 8.70708C7.15343 8.56723 7.05818 8.38903 7.01959 8.19505C6.98099 8.001 7.0008 7.79996 7.07646 7.6173C7.15211 7.43466 7.28032 7.27844 7.44484 7.16851C7.60928 7.05863 7.80256 7 8.00036 7C8.26552 7 8.51986 7.10535 8.70743 7.29292C8.89501 7.4805 9.00036 7.73484 9.00036 8C9.00036 8.19779 8.94172 8.39108 8.83185 8.55551ZM9.66332 9.11108C9.88308 8.78219 10.0004 8.39556 10.0004 8C10.0004 7.46957 9.78961 6.96089 9.41454 6.58582C9.03947 6.21074 8.53079 6 8.00036 6C7.60479 6 7.21817 6.11727 6.88927 6.33704C6.56037 6.5568 6.30395 6.86917 6.15258 7.23462C6.0012 7.60007 5.96164 8.00217 6.03881 8.39014C6.11598 8.7781 6.30647 9.13448 6.58617 9.41418C6.86588 9.69389 7.22226 9.88438 7.61022 9.96155C7.99818 10.0387 8.40028 9.99915 8.76574 9.84778C9.13119 9.6964 9.44356 9.43998 9.66332 9.11108Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
