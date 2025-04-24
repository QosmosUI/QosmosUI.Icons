// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiEmlakjet : ComponentBase
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
		builder.AddAttribute(15, "d", "M15.65 16.105v-.24a3.543 3.543 0 00-1.267-2.471c-.724-.663-1.69-.965-2.655-.904-1.87.12-3.378 1.747-3.378 3.615 0 .784.12 1.567.422 2.471H4.55V6.946l7.42-5.123 7.482 5.122v11.692h-4.223c.18-.663.422-1.688.422-2.532m5.068-10.244L12.452.136c-.301-.181-.663-.181-.905 0L3.222 5.86c-.242.12-.362.361-.362.663V19.48c0 .482.362.844.844.844H9.92a.824.824 0 00.844-.844c0-.06 0-.18-.06-.24l-.06-.182c-.302-.723-.664-1.627-.664-2.53v-.182c-.06-.542.12-1.084.482-1.446a2.095 2.095 0 011.388-.723c.543-.06 1.026.12 1.448.482.422.362.664.844.724 1.386v.18c.06 1.206-.724 2.954-.845 3.135l-1.146 2.17-.18-.362c-.122-.181-.302-.362-.483-.422-.182-.06-.423-.06-.604.06-.18.12-.362.301-.422.482s-.06.422.06.603l.905 1.687c.121.241.423.422.724.422.302 0 .604-.18.724-.422l1.81-3.375h5.732a.824.824 0 00.844-.843V6.524c-.06-.302-.18-.543-.422-.663");
		builder.CloseElement();
		builder.CloseElement();
    }
}
