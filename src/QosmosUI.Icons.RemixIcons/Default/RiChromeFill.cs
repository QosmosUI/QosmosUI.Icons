// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiChromeFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M9.82726 21.7633C5.34912 20.7712 2 16.7767 2 12C2 10.1779 2.48734 8.46958 3.33878 6.99834L7.62189 14.4169C8.47396 15.9571 10.1152 17 12 17C12.2023 17 12.4018 16.988 12.5978 16.9646L9.82726 21.7633ZM12 22L16.2868 14.5751C16.7396 13.8229 17 12.9419 17 12C17 10.8744 16.6281 9.83566 16.0004 9H21.5422C21.8396 9.94704 22 10.9548 22 12C22 17.5228 17.5228 22 12 22ZM14.5721 13.545C14.0473 14.4168 13.0917 15 12 15C10.8897 15 9.92024 14.3968 9.40149 13.5002L9.37313 13.4501C9.13535 13.0203 9 12.526 9 12C9 10.3431 10.3431 9 12 9C13.6569 9 15 10.3431 15 12C15 12.5465 14.8539 13.0589 14.5985 13.5002L14.5721 13.545ZM4.6322 5.23859C6.46008 3.24783 9.08432 2 12 2C15.7014 2 18.9331 4.01099 20.6622 7H12C9.93635 7 8.1647 8.25019 7.40112 10.0345L4.6322 5.23859Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
