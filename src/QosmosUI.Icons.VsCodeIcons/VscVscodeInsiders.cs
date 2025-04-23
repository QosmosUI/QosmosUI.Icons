// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons;

public class VscVscodeInsiders : ComponentBase
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
		builder.AddAttribute(14, "d", "M9.7851 1.38057L5.56484 5.25075L7.68844 6.87108L10 5.10733V2C10 1.76607 9.91968 1.5509 9.7851 1.38057Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M10 9.89268L2.58433 4.23442C2.37657 4.0759 2.08597 4.08889 1.89301 4.26532L1.17719 4.91984C1.08223 5.00667 1.02543 5.11898 1.00681 5.23629C0.979153 5.41056 1.03574 5.59585 1.17661 5.72504L9.7851 13.6194C9.91968 13.4491 10 13.2339 10 13V9.89268Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M10.7532 1.0368C10.9105 1.32251 11 1.65081 11 2V13C11 13.3492 10.9105 13.6775 10.7532 13.9632C10.7906 13.9515 10.8274 13.9369 10.8634 13.9195L13.5399 12.625C13.8211 12.4889 14 12.2028 14 11.8889V3.11109C14 2.79721 13.8212 2.5111 13.5399 2.37507L10.8634 1.08048C10.8274 1.06306 10.7906 1.04852 10.7532 1.0368Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M1.17661 9.27496L2.37233 8.17842L4.00854 9.6789L2.58433 10.7656C2.37657 10.9241 2.08597 10.9111 1.89301 10.7347L1.17719 10.0802C0.941168 9.86437 0.940898 9.49112 1.17661 9.27496Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
