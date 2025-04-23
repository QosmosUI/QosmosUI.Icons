// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiOpenChest : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M457.03 213.037L416.514 100.24C425 77.232 433.27 68.075 437.527 64.633c3.162-2.563 5.922-3.534 8.185-2.904 4.134 1.168 8.775 7.7 12.278 17.456 11.266 31.347 10.377 87.094-.96 133.85zm-324.287-17.9l312.804 34.84-43.82-122.1L145.558 79.34c2.593 36.102-1.913 79.913-12.817 115.796zM128.98 77.5l-45.06-5.02 37.03 103.123c7.773-32.06 10.625-68.357 8.03-98.102zM101.46 27.19c-3.793 3.1-10.77 10.666-18.25 28.566L402.23 91.3c5.333-13.695 11.37-24.702 17.88-32.495L108.796 24.13c-2.573-.29-5.415 1.51-7.338 3.06zm280.63 283.338l.61 169.352 66.352-53.63-.61-169.35zM366.163 487.9L46.62 452.306 46 278.396l319.553 35.594zM216.726 337.648a9.777 9.777 0 0 0 5.168-9.405c-.248-6.367-5.364-12.092-11.43-12.857h-.125c-6.14-.693-10.904 3.927-10.646 10.335a13.973 13.973 0 0 0 5.767 10.543l-2.17 25.073 17.57 2.005zm219.28-91.983l-307.46-34.25v59.54l242.712 27.037zM58.31 263.13l54.34 6.058v-49.98z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
