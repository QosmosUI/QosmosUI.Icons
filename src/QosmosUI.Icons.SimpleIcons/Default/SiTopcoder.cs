// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiTopcoder : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.004 7.555c-1.87 0-3.88.979-5.559 2.678 1.741.384 3.587.997 5.046 1.662l.513.23c.204-.09.367-.163.513-.23 1.464-.667 3.318-1.282 5.064-1.667-1.645-1.796-3.508-2.673-5.577-2.673zm8.751 2.723c-.675.016-1.44.101-2.282.254.608.784 1.26 2 1.928 3.503a43.559 43.559 0 0 1 .981 2.4c.305-.06.58-.232.825-.542 1.393-1.761 2.038-3.366 1.708-4.349-.26-.776-1.152-1.19-2.515-1.258a8.77 8.77 0 0 0-.645-.008zm-17.506 0a8.844 8.844 0 0 0-.646.008c-1.365.068-2.258.481-2.518 1.258-.33.983.315 2.588 1.708 4.35.258.325.549.499.873.55.15-1.468 1.501-4.253 2.868-5.911a14.877 14.877 0 0 0-2.285-.254zm14.69.352c-1.184.197-3.63.971-5.15 1.638l-.036.017a10.22 10.22 0 0 1 1.798.599c1.268.55 1.504.694 5.169 3.06.206.134.37.227.587.32.194.084.383.143.566.174a42.717 42.717 0 0 0-1.316-3.092c-.46-.96-.906-1.758-1.323-2.338-.1-.14-.2-.266-.295-.378zm-11.866.004c-1.35 1.538-2.758 4.38-2.927 5.802.361-.061.79-.24 1.222-.49.317-.185.65-.394 1.054-.659.243-.16 1.153-.768 1.087-.724 1.939-1.29 3.253-1.982 4.678-2.288-1.589-.69-3.798-1.417-5.114-1.64z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
