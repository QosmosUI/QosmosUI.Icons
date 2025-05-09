// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscCopilotUnavailable : ComponentBase
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
		builder.AddAttribute(14, "d", "M6.99999 9.769V11.269C6.99999 11.683 6.66399 12.019 6.24999 12.019C5.83599 12.019 5.49999 11.683 5.49999 11.269V9.769C5.49999 9.355 5.83599 9.019 6.24999 9.019C6.66399 9.019 6.99999 9.355 6.99999 9.769ZM16 9.755V11.019C16 11.259 15.914 11.457 15.844 11.586C15.769 11.723 15.675 11.847 15.585 11.952C15.405 12.162 15.181 12.365 14.98 12.532C14.918 12.584 14.859 12.629 14.798 12.677L13 10.879V7.843L12.977 7.727C12.487 7.937 11.902 8.018 11.25 8.018C10.774 8.018 10.349 7.948 9.95599 7.834L6.93599 4.814C6.96199 4.69 6.98799 4.565 7.00599 4.425C7.12299 3.489 6.96799 3.029 6.76399 2.811C6.57099 2.604 6.12699 2.397 5.08299 2.513C4.93699 2.529 4.82599 2.556 4.70199 2.579L3.48999 1.367C3.90699 1.201 4.37599 1.082 4.91699 1.022C6.12299 0.888 7.17899 1.056 7.86099 1.787C7.90999 1.84 7.95699 1.895 7.99999 1.951C8.04299 1.895 8.08999 1.84 8.13899 1.787C8.82099 1.056 9.87699 0.888 11.083 1.022C12.313 1.159 13.229 1.55 13.807 2.283C14.372 2.999 14.5 3.897 14.5 4.768C14.5 5.34 14.447 5.915 14.246 6.423L14.414 7.261L14.48 7.294C15.412 7.76 16 8.712 16 9.754V9.755ZM13 4.769C13 4.003 12.878 3.527 12.63 3.214C12.396 2.918 11.937 2.628 10.917 2.514C9.87299 2.398 9.42899 2.605 9.23599 2.812C9.03199 3.03 8.87699 3.49 8.99399 4.426C9.08499 5.152 9.29599 5.656 9.61199 5.978C9.91099 6.283 10.396 6.519 11.25 6.519C12.172 6.519 12.529 6.32 12.692 6.139C12.871 5.939 13 5.561 13 4.769ZM14.854 14.146C15.049 14.341 15.049 14.658 14.854 14.853C14.756 14.951 14.628 14.999 14.5 14.999C14.372 14.999 14.244 14.95 14.146 14.853L13.063 13.77C12.861 13.871 12.639 13.976 12.386 14.083C11.295 14.546 9.75499 15.018 7.99899 15.018C6.24299 15.018 4.70299 14.546 3.61199 14.083C3.06399 13.851 2.62299 13.618 2.31599 13.441C2.05999 13.294 1.81399 13.134 1.57499 12.961C1.42599 12.853 1.22299 12.702 1.01799 12.531C0.816986 12.364 0.592986 12.161 0.412986 11.951C0.322986 11.846 0.228986 11.722 0.153986 11.585C0.0839858 11.456 -0.00201416 11.257 -0.00201416 11.018V9.754C-0.00201416 8.712 0.586986 7.76 1.51799 7.294L1.58399 7.261L1.75199 6.423C1.55099 5.915 1.49799 5.34 1.49799 4.768C1.49799 4.044 1.60199 3.308 1.95899 2.667L1.14499 1.853C0.949986 1.658 0.949986 1.341 1.14499 1.146C1.33999 0.951 1.65699 0.951 1.85199 1.146L14.852 14.146H14.854ZM3.10299 3.81C3.03699 4.065 2.99999 4.376 2.99999 4.769C2.99999 5.561 3.12899 5.94 3.30799 6.139C3.46999 6.32 3.82799 6.519 4.74999 6.519C5.13099 6.519 5.43399 6.47 5.68199 6.39L3.10299 3.81ZM11.935 12.642L10.5 11.207V11.269C10.5 11.683 10.164 12.019 9.74999 12.019C9.33599 12.019 8.99999 11.683 8.99999 11.269V9.769C8.99999 9.749 9.00099 9.73 9.00399 9.711L6.81699 7.524C6.25099 7.854 5.55999 8.019 4.75099 8.019C4.09899 8.019 3.51399 7.937 3.02399 7.728L3.00099 7.844V12.105L3.06599 12.143C3.32899 12.294 3.71599 12.499 4.19999 12.704C5.17099 13.116 6.50699 13.519 8.00099 13.519C9.49499 13.519 10.83 13.116 11.802 12.704C11.851 12.683 11.894 12.663 11.937 12.643L11.935 12.642Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
